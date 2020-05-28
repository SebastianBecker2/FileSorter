namespace FileSorter
{
    partial class Config
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
            this.BtnSelectSourcePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSourcePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LsbDestinationPaths = new System.Windows.Forms.ListBox();
            this.BtnAddDestinationPath = new System.Windows.Forms.Button();
            this.BtnRemoveDestinationPath = new System.Windows.Forms.Button();
            this.BtnOkay = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LsbExceptionPaths = new System.Windows.Forms.ListBox();
            this.BtnRemoveExceptionPath = new System.Windows.Forms.Button();
            this.BtnAddExceptionPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSelectSourcePath
            // 
            this.BtnSelectSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectSourcePath.Location = new System.Drawing.Point(468, 10);
            this.BtnSelectSourcePath.Name = "BtnSelectSourcePath";
            this.BtnSelectSourcePath.Size = new System.Drawing.Size(21, 23);
            this.BtnSelectSourcePath.TabIndex = 5;
            this.BtnSelectSourcePath.Text = "...";
            this.BtnSelectSourcePath.UseVisualStyleBackColor = true;
            this.BtnSelectSourcePath.Click += new System.EventHandler(this.BtnSelectSourcePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source Path:";
            // 
            // TxtSourcePath
            // 
            this.TxtSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSourcePath.Location = new System.Drawing.Point(106, 12);
            this.TxtSourcePath.Name = "TxtSourcePath";
            this.TxtSourcePath.Size = new System.Drawing.Size(356, 20);
            this.TxtSourcePath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination Path:";
            // 
            // LsbDestinationPaths
            // 
            this.LsbDestinationPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsbDestinationPaths.FormattingEnabled = true;
            this.LsbDestinationPaths.Location = new System.Drawing.Point(94, 3);
            this.LsbDestinationPaths.Name = "LsbDestinationPaths";
            this.LsbDestinationPaths.Size = new System.Drawing.Size(356, 147);
            this.LsbDestinationPaths.TabIndex = 7;
            // 
            // BtnAddDestinationPath
            // 
            this.BtnAddDestinationPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddDestinationPath.Location = new System.Drawing.Point(456, 3);
            this.BtnAddDestinationPath.Name = "BtnAddDestinationPath";
            this.BtnAddDestinationPath.Size = new System.Drawing.Size(21, 23);
            this.BtnAddDestinationPath.TabIndex = 8;
            this.BtnAddDestinationPath.Text = "+";
            this.BtnAddDestinationPath.UseVisualStyleBackColor = true;
            this.BtnAddDestinationPath.Click += new System.EventHandler(this.BtnAddDestinationPath_Click);
            // 
            // BtnRemoveDestinationPath
            // 
            this.BtnRemoveDestinationPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveDestinationPath.Location = new System.Drawing.Point(456, 32);
            this.BtnRemoveDestinationPath.Name = "BtnRemoveDestinationPath";
            this.BtnRemoveDestinationPath.Size = new System.Drawing.Size(21, 23);
            this.BtnRemoveDestinationPath.TabIndex = 9;
            this.BtnRemoveDestinationPath.Text = "-";
            this.BtnRemoveDestinationPath.UseVisualStyleBackColor = true;
            this.BtnRemoveDestinationPath.Click += new System.EventHandler(this.BtnRemoveDestinationPath_Click);
            // 
            // BtnOkay
            // 
            this.BtnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOkay.Location = new System.Drawing.Point(333, 380);
            this.BtnOkay.Name = "BtnOkay";
            this.BtnOkay.Size = new System.Drawing.Size(75, 23);
            this.BtnOkay.TabIndex = 10;
            this.BtnOkay.Text = "OK";
            this.BtnOkay.UseVisualStyleBackColor = true;
            this.BtnOkay.Click += new System.EventHandler(this.BtnOkay_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(414, 380);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // LsbExceptionPaths
            // 
            this.LsbExceptionPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsbExceptionPaths.FormattingEnabled = true;
            this.LsbExceptionPaths.Location = new System.Drawing.Point(94, 3);
            this.LsbExceptionPaths.Name = "LsbExceptionPaths";
            this.LsbExceptionPaths.Size = new System.Drawing.Size(356, 147);
            this.LsbExceptionPaths.TabIndex = 12;
            // 
            // BtnRemoveExceptionPath
            // 
            this.BtnRemoveExceptionPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveExceptionPath.Location = new System.Drawing.Point(456, 32);
            this.BtnRemoveExceptionPath.Name = "BtnRemoveExceptionPath";
            this.BtnRemoveExceptionPath.Size = new System.Drawing.Size(21, 23);
            this.BtnRemoveExceptionPath.TabIndex = 14;
            this.BtnRemoveExceptionPath.Text = "-";
            this.BtnRemoveExceptionPath.UseVisualStyleBackColor = true;
            this.BtnRemoveExceptionPath.Click += new System.EventHandler(this.BtnRemoveExceptionPath_Click);
            // 
            // BtnAddExceptionPath
            // 
            this.BtnAddExceptionPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddExceptionPath.Location = new System.Drawing.Point(456, 3);
            this.BtnAddExceptionPath.Name = "BtnAddExceptionPath";
            this.BtnAddExceptionPath.Size = new System.Drawing.Size(21, 23);
            this.BtnAddExceptionPath.TabIndex = 13;
            this.BtnAddExceptionPath.Text = "+";
            this.BtnAddExceptionPath.UseVisualStyleBackColor = true;
            this.BtnAddExceptionPath.Click += new System.EventHandler(this.BtnAddExceptionPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Exceptions:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 39);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LsbDestinationPaths);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.BtnRemoveDestinationPath);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAddDestinationPath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.LsbExceptionPaths);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAddExceptionPath);
            this.splitContainer1.Panel2.Controls.Add(this.BtnRemoveExceptionPath);
            this.splitContainer1.Size = new System.Drawing.Size(477, 335);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 16;
            // 
            // Config
            // 
            this.AcceptButton = this.BtnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(501, 415);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOkay);
            this.Controls.Add(this.BtnSelectSourcePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSourcePath);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Config";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelectSourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSourcePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LsbDestinationPaths;
        private System.Windows.Forms.Button BtnAddDestinationPath;
        private System.Windows.Forms.Button BtnRemoveDestinationPath;
        private System.Windows.Forms.Button BtnOkay;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ListBox LsbExceptionPaths;
        private System.Windows.Forms.Button BtnRemoveExceptionPath;
        private System.Windows.Forms.Button BtnAddExceptionPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}