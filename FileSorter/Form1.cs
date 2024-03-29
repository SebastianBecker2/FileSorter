﻿using FileSorter.Properties;
using FuzzySharp;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSorter
{
    public partial class Form1 : Form
    {
        public string SourcePath
        {
            get { return Settings.Default.SourcePath; }
            set
            {
                Settings.Default.SourcePath = value;
                Settings.Default.Save();
            }
        }

        public List<string> DestinationPaths
        {
            get
            {
                return JsonConvert.DeserializeObject<List<string>>(Settings.Default.DestinationPaths);
            }
            set
            {
                Settings.Default.DestinationPaths = JsonConvert.SerializeObject(value);
                Settings.Default.Save();
            }
        }

        public List<string> ExceptionPaths
        {
            get
            {
                return JsonConvert.DeserializeObject<List<string>>(Settings.Default.ExceptionPaths);
            }
            set
            {
                Settings.Default.ExceptionPaths = JsonConvert.SerializeObject(value);
                Settings.Default.Save();
            }
        }

        private List<DestinationItem> FolderLookup;

        private OrderedSet<DestinationItem> RecentDestinationItems = new OrderedSet<DestinationItem>();

        public Form1()
        {
            InitializeComponent();
        }

        // Only used inside BtnFindFiles_Click
        // To preserve previous check box states
        // when searching for files a second time.
        private List<File> FilterableFiles;
        private void BtnFindFiles_Click(object sender, EventArgs e)
        {
            FolderLookup = DestinationPaths
                .SelectMany(dp => BuildFolderLookup(dp))
                .OrderByDescending(f => f.Key.Length).ToList();

            FilterableFiles = GetFilterableFiles(FolderLookup, FilterableFiles).ToList();
            DisplayFilteredFiles(FilterableFiles);
        }

        private void FileContextMenu_ReassignDestination(object sender, EventArgs e)
        {
            if (DgvSortedFiles.SelectedRows.Count <= 0)
            {
                return;
            }

            DestinationItem selected_destination;
            using (var dlg = new AssignDestination())
            {
                dlg.DestinationItems = FolderLookup;
                dlg.RecentDestinationItems = RecentDestinationItems;
                dlg.FileNames = DgvSortedFiles
                    .SelectedRows
                    .Cast<DataGridViewRow>()
                    .Select(r => r.Cells["dgcFileName"].Value as string);

                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                selected_destination = dlg.SelectedDestination;
                RecentDestinationItems.Add(dlg.SelectedDestination);
            }

            foreach (DataGridViewRow row in DgvSortedFiles.SelectedRows)
            {
                var file = row.Tag as File;
                file.DestinationFolderPath = selected_destination.Path;
                file.FilterKey = selected_destination.Key;
                file.Sort = true;
                row.Cells["dgcDestinationPath"].Value = selected_destination.Path;
                row.Cells["dgcFilteredKey"].Value = selected_destination.Key;
                row.Cells["dgcSort"].Value = true;
            }
        }

        private void FileContextMenu_CreateDestination(object sender, EventArgs e)
        {
            if (DgvSortedFiles.SelectedRows.Count <= 0)
            {
                return;
            }

            string new_destination;
            string new_path;
            using (var dlg = new CreateDestination())
            {
                dlg.DestinationPaths = DestinationPaths;
                dlg.FileNames = DgvSortedFiles
                    .SelectedRows
                    .Cast<DataGridViewRow>()
                    .Select(r => r.Cells["dgcFileName"].Value as string);

                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                new_destination = dlg.DestinationName;
                new_path = Path.Combine(dlg.SelectedDestinationPath, new_destination);
            }

            var items = new_destination
                .Split('(', ')', ',')
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .Select(n => new DestinationItem { Key = n, Path = new_path });

            FolderLookup.AddRange(items);

            Directory.CreateDirectory(new_path);

            foreach (DataGridViewRow row in DgvSortedFiles.SelectedRows)
            {
                var file = row.Tag as File;
                file.DestinationFolderPath = items.First().Path;
                file.FilterKey = items.First().Key;
                file.Sort = true;
                row.Cells["dgcDestinationPath"].Value = items.First().Path;
                row.Cells["dgcFilteredKey"].Value = items.First().Key;
                row.Cells["dgcSort"].Value = true;
            }
        }

        private void FileContextMenu_MoveFile(object sender, EventArgs e)
        {
            if (DgvSortedFiles.SelectedRows.Count <= 0)
            {
                return;
            }
            string destination_path;
            using (var dlg = new CommonOpenFileDialog())
            {
                dlg.IsFolderPicker = true;

                if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }

                destination_path = dlg.FileName;
            }

            foreach (DataGridViewRow row in DgvSortedFiles.SelectedRows)
            {
                var file = row.Tag as File;

                try
                {
                    System.IO.File.Move(file.FilePath, Path.Combine(destination_path, file.FileName));
                }
                catch (IOException exc)
                {
                    MessageBox.Show(exc.Message + Environment.NewLine + file.FileName);
                }

                DgvSortedFiles.Rows.Remove(row);
            }
        }

        private void FileContextMenu_ShowFileInfo(object sender, EventArgs e)
        {
            if (DgvSortedFiles.SelectedRows.Count <= 0)
            {
                return;
            }

            foreach (DataGridViewRow row in DgvSortedFiles.SelectedRows)
            {
                using (var dlg = new FileInfo())
                {
                    var file = row.Tag as File;
                    dlg.FilePath = file.FilePath;
                    dlg.ShowDialog();
                }
            }
        }

        private void DisplayFilteredFiles(IEnumerable<File> filtered_files)
        {
            DgvSortedFiles.Rows.Clear();

            var cms = new ContextMenuStrip();
            cms.Items.Add(new ToolStripMenuItem("Reassign Destination", null, FileContextMenu_ReassignDestination));
            cms.Items.Add(new ToolStripMenuItem("Create Destination", null, FileContextMenu_CreateDestination));
            cms.Items.Add(new ToolStripMenuItem("Move File", null, FileContextMenu_MoveFile));
            cms.Items.Add(new ToolStripMenuItem("Show File Info", null, FileContextMenu_ShowFileInfo));

            foreach (var file in filtered_files)
            {
                var row = new DataGridViewRow()
                {
                    Tag = file,
                    ContextMenuStrip = cms,
                };

                var chb_cell = new DataGridViewCheckBoxCell()
                {
                    Value = file.Sort,
                };
                row.Cells.Add(chb_cell);

                var cell = new DataGridViewTextBoxCell()
                {
                    Value = file.FilterKey,
                };
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell()
                {
                    Value = file.FileName,
                };
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell()
                {
                    Value = file.DestinationFolderPath,
                };
                row.Cells.Add(cell);

                DgvSortedFiles.Rows.Add(row);
            }

            DgvSortedFiles.Sort(DgvSortedFiles.Columns["dgcFilteredKey"], ListSortDirection.Ascending);
        }

        private IEnumerable<File> GetFilterableFiles(IEnumerable<DestinationItem> folder_lookup, IEnumerable<File> previous_files)
        {
            foreach (var file_path in Directory.EnumerateFiles(SourcePath, "*", SearchOption.TopDirectoryOnly))
            {
                var name = Path.GetFileName(file_path);
                var previous_file = previous_files?.FirstOrDefault(f => f.FileName == name);
                var previously_filtered = !string.IsNullOrWhiteSpace(previous_file?.FilterKey);

                ( int Ratio, string Key, string Path ) GetLikeliestFolder(string n) {
                    var f = folder_lookup
                        .Select(i => new {
                            Ratio = Fuzz.PartialRatio(i.Key, name),
                            Key = i.Key,
                            Path = i.Path
                        })
                        .Aggregate((f1, f2) => f1.Ratio > f2.Ratio ? f1 : f2);
                    return (f.Ratio, f.Key, f.Path);
                }

                File ToFile(string n, string key, string path)
                {
                    return new File
                    {
                        DestinationFolderPath = path,
                        FilePath = file_path,
                        FileName = name,
                        FilterKey = key,
                        Sort = previously_filtered ? previous_file.Sort : true,
                    };
                }

                var likeliestFolder = GetLikeliestFolder(name);
                if (likeliestFolder.Ratio > 75)
                {
                    yield return ToFile(name, likeliestFolder.Key, likeliestFolder.Path);
                    continue;
                }

                // Replacing all punctuation characters with whitespace might be better
                // but requires regex, so it might be too slow.
                name = name.Replace('_', ' ');

                likeliestFolder = GetLikeliestFolder(name);
                if (likeliestFolder.Ratio > 75)
                {
                    yield return ToFile(name, likeliestFolder.Key, likeliestFolder.Path);
                    continue;
                }

                yield return new File
                {
                    FilePath = file_path,
                    FileName = name,
                    Sort = false,
                };
            }
        }

        private IEnumerable<DestinationItem> BuildFolderLookup(string destination_path)
        {
            return Directory.EnumerateDirectories(destination_path, "*", SearchOption.TopDirectoryOnly)
                .Where(path => !ExceptionPaths.Contains(path))
                .SelectMany(path =>
                {
                    var name = Path.GetFileName(path);

                    var recorded_path = Directory.EnumerateDirectories(path, "recorded", SearchOption.TopDirectoryOnly);
                    if (recorded_path.Any())
                    {
                        path = recorded_path.First();
                    }

                    if (!name.Contains("("))
                    {
                        return new[] { new DestinationItem { Key = name, Path = path } };
                    }

                    return name
                        .Split('(', ')', ',')
                        .Where(n => !string.IsNullOrWhiteSpace(n))
                        .Select(n => new DestinationItem { Key = n, Path = path });
                });
        }

        private void DgvSortedFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;

            if (e.RowIndex < 0 || e.RowIndex >= dgv.RowCount)
            {
                return;
            }

            var file = dgv.Rows[e.RowIndex].Tag as File;

            new Task(() => System.Diagnostics.Process.Start(file.FilePath)).Start();
        }

        private void DgvSortedFiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ' ')
            {
                return;
            }

            var dgv = sender as DataGridView;

            bool? status = new bool?();
            foreach (var row in dgv.SelectedRows.Cast<DataGridViewRow>().Reverse())
            {
                var file = row.Tag as File;
                if (!status.HasValue)
                {
                    status = !file.Sort;
                }
                file.Sort = status.Value;


                var chb_cell = row.Cells["dgcSort"] as DataGridViewCheckBoxCell;
                chb_cell.Value = file.Sort;
            }
        }

        private void BtnShowConfig_Click(object sender, EventArgs e)
        {
            using (var dlg = new Config())
            {
                dlg.SourcePath = SourcePath;
                dlg.DestinationPaths = DestinationPaths;
                dlg.ExceptionPaths = ExceptionPaths;
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                SourcePath = dlg.SourcePath;
                DestinationPaths = dlg.DestinationPaths;
                ExceptionPaths = dlg.ExceptionPaths;
            }
        }

        private void BtnSortFiles_Click(object sender, EventArgs e)
        {
            foreach (var file in DgvSortedFiles.Rows
                .Cast<DataGridViewRow>()
                .Select(r => r.Tag as File)
                .Where(f => !string.IsNullOrWhiteSpace(f.FilterKey))
                .Where(f => f.Sort))
            {
                MoveFile(file.FilePath, Path.Combine(file.DestinationFolderPath, file.FileName));
            }

            BtnFindFiles.PerformClick();
        }

        private void MoveFile(string source, string destination)
        {
            try
            {
                System.IO.File.Move(source, destination);
            }
            catch (IOException exc)
            {
                if (!exc.Message.Contains("already exists"))
                {
                    return;
                }
                using (var dlg = new FileComparison())
                {
                    dlg.SourceFilePath = source;
                    dlg.DestinationFilePath = destination;
                    var result = dlg.ShowDialog();
                    switch (result)
                    {
                        case DialogResult.Cancel:
                            break;
                        case DialogResult.Ignore:
                            System.IO.File.Delete(destination);
                            MoveFile(source, destination);
                            break;
                        case DialogResult.OK:
                            destination = IncreaseFileCounter(destination);
                            MoveFile(source, destination);
                            break;
                        case DialogResult.No:
                            System.IO.File.Delete(source);
                            break;
                    }
                }
            }
        }

        private string IncreaseFileCounter(string file_path)
        {
            var name = Path.GetFileNameWithoutExtension(file_path);
            var extension = Path.GetExtension(file_path);
            var path = Path.GetDirectoryName(file_path);

            for (int i = 1; ; ++i)
            {
                if (!System.IO.File.Exists(file_path))
                {
                    return file_path;
                }

                file_path = Path.Combine(path, name + " " + i + extension);
            }
        }

        private void DgvSortedFiles_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dgv = sender as DataGridView;

            if (e.RowIndex < 0 || e.RowIndex >= dgv.RowCount || e.ColumnIndex < 0)
            {
                return;
            }

            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            var row = dgv.Rows[e.RowIndex] as DataGridViewRow;
            if (!row.Selected)
            {
                dgv.ClearSelection();
                dgv.CurrentCell = row.Cells[0];
                row.Selected = true;
            }
        }

        private void DgvSortedFiles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            var dgv = sender as DataGridView;

            if (dgv.IsCurrentCellDirty)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DgvSortedFiles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex].Name == "dgcSort")
            {
                var row = dgv.Rows[e.RowIndex] as DataGridViewRow;
                var file = row.Tag as File;
                var cell = dgv.Rows[e.RowIndex].Cells["dgcSort"] as DataGridViewCheckBoxCell;

                file.Sort = (bool)cell.Value;

                dgv.Invalidate();
            }
        }

        private void BtnShowToDoList_Click(object sender, EventArgs e)
        {
            using (var dlg = new ToDoManager.ToDoManager())
            {
                dlg.ShowDialog();
            }
        }
    }
}