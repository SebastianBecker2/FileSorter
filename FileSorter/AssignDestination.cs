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
    public partial class AssignDestination : Form
    {
        public IOrderedEnumerable<DestinationItem> DestinationItems { get; set; }
        public DestinationItem SelectedDestination { get; set; }

        public AssignDestination()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            DisplayDestinationItems(DestinationItems);

            base.OnLoad(e);
        }

        private void DisplayDestinationItems(IOrderedEnumerable<DestinationItem> destination_items)
        {
            DgvDestinations.Rows.Clear();

            foreach (var item in destination_items)
            {
                var row = new DataGridViewRow()
                {
                    Tag = item,
                };

                var cell = new DataGridViewTextBoxCell()
                {
                    Value = item.Key,
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
            if (DgvDestinations.SelectedRows.Count != 1)
            {
                return;
            }

            SelectedDestination = DgvDestinations.SelectedRows[0].Tag as DestinationItem;

            DialogResult = DialogResult.OK;
        }
    }
}
