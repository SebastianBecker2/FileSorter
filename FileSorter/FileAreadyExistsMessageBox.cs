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
    public partial class FileAreadyExistsMessageBox : Form
    {
        public string FileName { get; set; }

        public FileAreadyExistsMessageBox()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            lblMessage.Text = "The file already exists!" + Environment.NewLine + FileName + Environment.NewLine;

            base.OnLoad(e);
        }
    }
}
