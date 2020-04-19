namespace FileSorter
{
    partial class CreateDestination
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
            this.TxtFileName = new System.Windows.Forms.RichTextBox();
            this.TxtDestinationName = new System.Windows.Forms.TextBox();
            this.LsbDestinationPaths = new System.Windows.Forms.ListBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOkay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddSubName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtFileName
            // 
            this.TxtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFileName.BackColor = System.Drawing.SystemColors.Control;
            this.TxtFileName.Location = new System.Drawing.Point(12, 53);
            this.TxtFileName.Multiline = false;
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(313, 20);
            this.TxtFileName.TabIndex = 0;
            this.TxtFileName.Text = "";
            this.TxtFileName.Click += new System.EventHandler(this.TxtFileName_Click);
            this.TxtFileName.MouseLeave += new System.EventHandler(this.TxtFileName_MouseLeave);
            this.TxtFileName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TxtFileName_MouseMove);
            // 
            // TxtDestinationName
            // 
            this.TxtDestinationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDestinationName.Location = new System.Drawing.Point(12, 25);
            this.TxtDestinationName.Name = "TxtDestinationName";
            this.TxtDestinationName.Size = new System.Drawing.Size(386, 20);
            this.TxtDestinationName.TabIndex = 1;
            // 
            // LsbDestinationPaths
            // 
            this.LsbDestinationPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsbDestinationPaths.FormattingEnabled = true;
            this.LsbDestinationPaths.Location = new System.Drawing.Point(12, 95);
            this.LsbDestinationPaths.Name = "LsbDestinationPaths";
            this.LsbDestinationPaths.Size = new System.Drawing.Size(386, 277);
            this.LsbDestinationPaths.TabIndex = 8;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(323, 386);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOkay
            // 
            this.BtnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOkay.Location = new System.Drawing.Point(242, 386);
            this.BtnOkay.Name = "BtnOkay";
            this.BtnOkay.Size = new System.Drawing.Size(75, 23);
            this.BtnOkay.TabIndex = 14;
            this.BtnOkay.Text = "OK";
            this.BtnOkay.UseVisualStyleBackColor = true;
            this.BtnOkay.Click += new System.EventHandler(this.BtnOkay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "New folder name:";
            // 
            // BtnAddSubName
            // 
            this.BtnAddSubName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddSubName.Location = new System.Drawing.Point(331, 51);
            this.BtnAddSubName.Name = "BtnAddSubName";
            this.BtnAddSubName.Size = new System.Drawing.Size(67, 23);
            this.BtnAddSubName.TabIndex = 17;
            this.BtnAddSubName.Text = "Add Name";
            this.BtnAddSubName.UseVisualStyleBackColor = true;
            this.BtnAddSubName.Click += new System.EventHandler(this.BtnAddSubName_Click);
            // 
            // CreateDestination
            // 
            this.AcceptButton = this.BtnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(410, 421);
            this.Controls.Add(this.BtnAddSubName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOkay);
            this.Controls.Add(this.LsbDestinationPaths);
            this.Controls.Add(this.TxtDestinationName);
            this.Controls.Add(this.TxtFileName);
            this.Name = "CreateDestination";
            this.Text = "Create Destination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtFileName;
        private System.Windows.Forms.TextBox TxtDestinationName;
        private System.Windows.Forms.ListBox LsbDestinationPaths;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOkay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddSubName;
    }
}