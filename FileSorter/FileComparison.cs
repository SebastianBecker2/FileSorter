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
            var result = DialogResult;
            if (!SourceThumbnailTask.IsCompleted)
            {
                
                e.Cancel = true;
                FpvSource.CancelThumbnails();
                SourceThumbnailTask.ContinueWith(t => DialogResult = result,
                    TaskScheduler.FromCurrentSynchronizationContext());
            }

            if (!DestinationThumbnailTask.IsCompleted)
            {
                e.Cancel = true;
                FpvDestination.CancelThumbnails();
                DestinationThumbnailTask.ContinueWith(t => DialogResult = result,
                    TaskScheduler.FromCurrentSynchronizationContext());
            }

            base.OnFormClosing(e);
        }

        private void FpvSource_FileInfoLoaded(object sender, FileInfoLoadedEventArgs e)
        {
            if (FpvDestination.FileInfo == null)
            {
                return;
            }

            TryAutoCompare();
        }

        private void FpvDestination_FileInfoLoaded(object sender, FileInfoLoadedEventArgs e)
        {
            if (FpvSource.FileInfo == null)
            {
                return;
            }

            TryAutoCompare();
        }

        private void TryAutoCompare()
        {
            var dest_dur = FpvDestination.FileInfo.Duration;
            var src_dur = FpvSource.FileInfo.Duration;
            var dur_diff = Math.Abs((dest_dur - src_dur).TotalSeconds);
            if (dur_diff > 10)
            {
                // Files are too different
                // User has to decide
                return;
            }

            var dest_size = FpvDestination.FileSize;
            var src_size = FpvSource.FileSize;
            var size_diff = Math.Abs(dest_size - src_size);
            if (src_size - dest_size < 100 * 1024)
            {
                FpvDestination.HighlightColor = Color.LightGreen;
            }
            else
            {
                FpvSource.HighlightColor = Color.LightGreen;
            }
        }
    }
}
