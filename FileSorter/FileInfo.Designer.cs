namespace FileSorter
{
    partial class FileInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FpvFileInfo = new FileSorter.FilePreview();
            this.BtnOkay = new System.Windows.Forms.Button();
            this.LblFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FpvFileInfo
            // 
            this.FpvFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FpvFileInfo.Location = new System.Drawing.Point(12, 29);
            this.FpvFileInfo.Name = "FpvFileInfo";
            this.FpvFileInfo.Size = new System.Drawing.Size(422, 464);
            this.FpvFileInfo.TabIndex = 0;
            // 
            // BtnOkay
            // 
            this.BtnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOkay.Location = new System.Drawing.Point(360, 499);
            this.BtnOkay.Name = "BtnOkay";
            this.BtnOkay.Size = new System.Drawing.Size(75, 23);
            this.BtnOkay.TabIndex = 15;
            this.BtnOkay.Text = "OK";
            this.BtnOkay.UseVisualStyleBackColor = true;
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(13, 13);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(35, 13);
            this.LblFileName.TabIndex = 16;
            this.LblFileName.Text = "label1";
            // 
            // FileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 534);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.BtnOkay);
            this.Controls.Add(this.FpvFileInfo);
            this.Name = "FileInfo";
            this.Text = "FileInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FilePreview FpvFileInfo;
        private System.Windows.Forms.Button BtnOkay;
        private System.Windows.Forms.Label LblFileName;
    }
}