﻿using Newtonsoft.Json;
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
using ToDoManager.Properties;

namespace ToDoManager
{
    public partial class ToDoManager : Form
    {
        List<ToDoItem> ToDoItems
        {
            get { return JsonConvert.DeserializeObject<List<ToDoItem>>(Settings.Default.ToDoListItem); }
            set
            {
                Settings.Default.ToDoListItem = JsonConvert.SerializeObject(value);
                Settings.Default.Save();
            }
        }

        public ToDoManager()
        {
            InitializeComponent();

            if (ToDoItems == null)
            {
                ToDoItems = new List<ToDoItem>();
            }

            DgvToDoList.Columns["DgcText"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvToDoList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        protected override void OnLoad(EventArgs e)
        {
            DisplayToDoList(ToDoItems);

            ApplyFilterToDgv();

            base.OnLoad(e);
        }

        private void DisplayToDoList(IEnumerable<ToDoItem> items)
        {
            DgvToDoList.Rows.Clear();

            foreach (var item in items.OrderBy(i => i.Done))
            {
                var row = new DataGridViewRow();

                var chb_cell = new DataGridViewCheckBoxCell()
                {
                    Value = item.Done,
                };
                row.Cells.Add(chb_cell);

                var text_cell = new DataGridViewTextBoxCell()
                {
                    Value = item.Text,
                };
                row.Cells.Add(text_cell);

                var delete_cell = new DataGridViewButtonCell()
                {
                    Value = "X",
                    
                };
                row.Cells.Add(delete_cell);

                DgvToDoList.Rows.Add(row);
            }
        }

        private List<ToDoItem> GetToDoItemsFromDgv()
        {
            return DgvToDoList.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => new ToDoItem
                {
                    Done = (bool)(r.Cells["DgcDone"] as DataGridViewCheckBoxCell).Value,
                    Text = r.Cells["DgcText"].Value as string
                })
                .ToList();
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            ToDoItems = GetToDoItemsFromDgv();

            DialogResult = DialogResult.OK;
        }

        private void DgvToDoList_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["DgcDone"].Value = false;
            e.Row.Cells["DgcText"].Value = "";
            e.Row.Cells["DgcDelete"].Value = "X";
        }

        private void DgvToDoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvToDoList.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            if (DgvToDoList.Columns["DgcDelete"].Index != e.ColumnIndex)
            {
                return;
            }

            DgvToDoList.Rows.RemoveAt(e.RowIndex);
        }

        private void ChbShowCompletedItems_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilterToDgv();
        }

        private void ApplyFilterToDgv()
        {
            foreach (var row in DgvToDoList.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Where(r => (bool)(r.Cells["DgcDone"] as DataGridViewCheckBoxCell).Value))
            {
                row.Visible = ChbShowCompletedItems.Checked;
            }
        }
    }
}
