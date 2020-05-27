using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSorter
{
    public partial class FileComparison : Form
    {
        public string SourceFilePath { get; set; }
        public string DestinationFilePath { get; set; }

        private Task SourceThumbnailTask;
        private Task DestinationThumbnailTask;

        public FileComparison()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            SplitterContainer.SplitterDistance = SplitterContainer.Width / 2;

            LblFilePath.Text = DestinationFilePath;

            SourceThumbnailTask = FpvSource.LoadFile(SourceFilePath);
            DestinationThumbnailTask = FpvDestination.LoadFile(DestinationFilePath);

            base.OnLoad(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!SourceThumbnailTask.IsCompleted)
            {
                e.Cancel = true;
                FpvSource.CancelThumbnails();
                SourceThumbnailTask.ContinueWith(t => Close(), TaskScheduler.FromCurrentSynchronizationContext());
            }

            if (!DestinationThumbnailTask.IsCompleted)
            {
                e.Cancel = true;
                FpvDestination.CancelThumbnails();
                DestinationThumbnailTask.ContinueWith(t => Close(), TaskScheduler.FromCurrentSynchronizationContext());
            }

            base.OnFormClosing(e);
        }
    }
}
