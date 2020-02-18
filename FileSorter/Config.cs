using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSorter
{
    public partial class Config : Form
    {
        public string SourcePath { get; set; }
        public List<string> DestinationPaths { get; set; }

        public Config()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            TxtSourcePath.Text = SourcePath;
            if (DestinationPaths != null)
            {
                LsbDestinationPaths.Items.AddRange(DestinationPaths.ToArray());
            }

            base.OnLoad(e);
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            SourcePath = TxtSourcePath.Text;
            DestinationPaths = LsbDestinationPaths.Items.Cast<string>().ToList();
            DialogResult = DialogResult.OK;
        }

        private void BtnAddDestinationPath_Click(object sender, EventArgs e)
        {
            using (var dlg = new CommonOpenFileDialog())
            {
                dlg.IsFolderPicker = true;

                if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }

                LsbDestinationPaths.Items.Add(dlg.FileName);
            }
        }

        private void BtnSelectSourcePath_Click(object sender, EventArgs e)
        {
            using (var dlg = new CommonOpenFileDialog())
            {
                dlg.IsFolderPicker = true;

                if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }

                TxtSourcePath.Text = dlg.FileName;
            }
        }

        private void BtnRemoveDestinationPath_Click(object sender, EventArgs e)
        {
            foreach (var s in LsbDestinationPaths.SelectedItems.OfType<string>().ToList())
            {
                LsbDestinationPaths.Items.Remove(s);
            }
        }
    }
}
