using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace FileSorter
{
    public partial class FilePreview : UserControl
    {
        private static readonly int ThumbnailCount = 20;
        private static readonly Size ThumbnailSize = new Size(256, 256);
        private static readonly ColorDepth ThumbnailColorDepth = ColorDepth.Depth32Bit;

        private CancellationTokenSource CancelTokenSource = new CancellationTokenSource();

        public FilePreview()
        {
            InitializeComponent();

            ImlThumbnails.ColorDepth = ThumbnailColorDepth;
        }

        /// <summary>
        /// Scales to images to max 256x256
        /// but keeping the aspect ratio
        /// </summary>
        /// <param name="original_size"></param>
        private void SetImageSize(Size original_size)
        {
            var width = original_size.Width;
            var height = original_size.Height;

            if (width > height)
            {
                height = (int)(height / ((double)width / ThumbnailSize.Width));
                ImlThumbnails.ImageSize = new Size(ThumbnailSize.Width, height);
            }
            else
            {
                width = (int)(width / ((double)height / ThumbnailSize.Height));
                ImlThumbnails.ImageSize = new Size(width, ThumbnailSize.Height);
            }
        }

        private void DisplayInfo(NReco.VideoInfo.MediaInfo info)
        {
            var duration_format = info.Duration.Hours >= 1 ? @"hh\:mm\:ss" : @"mm\:ss";
            TxtInfo.Text += info.Duration.ToString(duration_format) + Environment.NewLine;

            var stream = info.Streams.FirstOrDefault(s => s.CodecType == "video");
            if (stream == null)
            {
                return;
            }
            TxtInfo.Text += stream.Width.ToString() +
                " x " + stream.Height.ToString() +
                " @ " + stream.FrameRate + " Frames" + Environment.NewLine +
                stream.CodecLongName;
        }

        public Task LoadFile(string file_path)
        {
            var probe = new NReco.VideoInfo.FFProbe();
            var info = probe.GetMediaInfo(file_path);

            TxtInfo.Text = (new System.IO.FileInfo(file_path).Length / (1024 * 1024)).ToString() +
                " MB" + Environment.NewLine;
            DisplayInfo(info);

            var width = info.Streams.First().Width;
            var height = info.Streams.First().Height;
            SetImageSize(new Size(width, height));

            var duration = info.Duration;

            var step = (int)(duration.TotalSeconds / (ThumbnailCount + 1));

            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            var cancel_token = CancelTokenSource.Token;
            return Task.Run(() =>
            {
                for (int i = 1; i < ThumbnailCount; i++)
                {
                    var image_stream = new MemoryStream();
                    ffMpeg.GetVideoThumbnail(file_path, image_stream, step * i);
                    if (image_stream.Length > 0)
                    {
                        var image = Image.FromStream(image_stream);
                    }

                    if (cancel_token.IsCancellationRequested)
                    {
                        Debug.Print("Task cancelled");
                        return;
                    }
                    Invoke((Action)delegate
                    {
                        ImlThumbnails.Images.Add(Image.FromStream(image_stream));
                        LsvThumbnails.Items.Add(new ListViewItem { ImageIndex = i });
                    });
                }
            }, CancelTokenSource.Token).ContinueWith(t => CancelTokenSource.Dispose());
        }

        public void CancelThumbnails()
        {
            Debug.Print("Cancellation requested");
            CancelTokenSource.Cancel();
        }
    }
}
