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
    public partial class FileInfo : Form
    {
        public string FilePath { get; set; }

        private Task ThumbnailTask;

        public FileInfo()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ThumbnailTask = FpvFileInfo.LoadFile(FilePath);
            base.OnLoad(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!ThumbnailTask.IsCompleted)
            {
                e.Cancel = true;
                FpvFileInfo.CancelThumbnails();
                ThumbnailTask.ContinueWith(t => Close(), TaskScheduler.FromCurrentSynchronizationContext());
            }

            base.OnFormClosing(e);
        }
    }
}
