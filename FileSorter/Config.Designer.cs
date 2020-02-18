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
            this.SuspendLayout();
            // 
            // BtnSelectSourcePath
            // 
            this.BtnSelectSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectSourcePath.Location = new System.Drawing.Point(404, 10);
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
            this.TxtSourcePath.Size = new System.Drawing.Size(289, 20);
            this.TxtSourcePath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
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
            this.LsbDestinationPaths.Location = new System.Drawing.Point(106, 46);
            this.LsbDestinationPaths.Name = "LsbDestinationPaths";
            this.LsbDestinationPaths.Size = new System.Drawing.Size(289, 134);
            this.LsbDestinationPaths.TabIndex = 7;
            // 
            // BtnAddDestinationPath
            // 
            this.BtnAddDestinationPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddDestinationPath.Location = new System.Drawing.Point(404, 41);
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
            this.BtnRemoveDestinationPath.Location = new System.Drawing.Point(404, 70);
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
            this.BtnOkay.Location = new System.Drawing.Point(269, 190);
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
            this.BtnCancel.Location = new System.Drawing.Point(350, 190);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // Config
            // 
            this.AcceptButton = this.BtnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(437, 225);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOkay);
            this.Controls.Add(this.BtnRemoveDestinationPath);
            this.Controls.Add(this.BtnAddDestinationPath);
            this.Controls.Add(this.LsbDestinationPaths);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSelectSourcePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSourcePath);
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Config";
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
    }
}