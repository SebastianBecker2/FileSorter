using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoreLinq;

namespace FileSorter
{
    public partial class AssignDestination : Form
    {
        public IEnumerable<DestinationItem> DestinationItems { get; set; }
        public IEnumerable<DestinationItem> RecentDestinationItems { get; set; }
        public DestinationItem SelectedDestination { get; set; }
        public IEnumerable<string> FileNames { get; set; }

        private string FileNamePrefix { get; set; }

        public AssignDestination()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            DisplayDestinationItems(DestinationItems);
            DisplayRecentDestinationItems(RecentDestinationItems);

            DgvDestinations.ClearSelection();
            DgvRecentDestinations.ClearSelection();

            FileNamePrefix = LblFileName.Text;
            LblFileName.Text = FileNamePrefix + " " + FileNames.FirstOrDefault();
            TipFileName.SetToolTip(LblFileName, string.Join("\r\n", FileNames.ToArray()));
            
            base.OnLoad(e);
        }

        private void DisplayRecentDestinationItems(IEnumerable<DestinationItem> recent_destination_items)
        {
            DgvRecentDestinations.Rows.Clear();

            foreach (var item in recent_destination_items.Reverse())
            {
                var row = new DataGridViewRow()
                {
                    Tag = item,
                };

                var cell = new DataGridViewTextBoxCell()
                {
                    Value = item.Key.Trim(),
                };
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell()
                {
                    Value = item.Path,
                };
                row.Cells.Add(cell);

                DgvRecentDestinations.Rows.Add(row);
            }
        }

        private void DisplayDestinationItems(IEnumerable<DestinationItem> destination_items)
        {
            DgvDestinations.Rows.Clear();

            foreach (var item in destination_items.DistinctBy(i => i.Path))
            {
                var row = new DataGridViewRow()
                {
                    Tag = item,
                };

                var cell = new DataGridViewTextBoxCell()
                {
                    Value = item.Key.Trim(),
                };
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell()
                {
                    Value = item.Path,
                };
                row.Cells.Add(cell);

                DgvDestinations.Rows.Add(row);
            }

            DgvDestinations.Sort(DgvDestinations.Columns["dgcKey"], ListSortDirection.Ascending);
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            if (DgvDestinations.SelectedRows.Count == 1)
            {
                SelectedDestination = DgvDestinations.SelectedRows[0].Tag as DestinationItem;
            }

            if (DgvRecentDestinations.SelectedRows.Count == 1)
            {
                SelectedDestination = DgvRecentDestinations.SelectedRows[0].Tag as DestinationItem;
            }

            DialogResult = DialogResult.OK;
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            var filtered_items = DestinationItems
                .Where(i => i.Key.ToLower().Contains(TxtFilter.Text.ToLower()));

            DisplayDestinationItems(filtered_items);
        }

        private void DgvDestinations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DgvDestinations.Rows[e.RowIndex].Selected = true;
            BtnOkay.PerformClick();
        }

        private void DgvRecentDestinations_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DgvRecentDestinations.Rows[e.RowIndex].Selected = true;
            BtnOkay.PerformClick();
        }

        private void DgvDestinations_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvDestinations.SelectedRows.Count > 0)
            {
                DgvRecentDestinations.ClearSelection();
            }
        }

        private void DgvRecentDestinations_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvRecentDestinations.SelectedRows.Count > 0)
            {
                DgvDestinations.ClearSelection();
            }
        }
    }
}