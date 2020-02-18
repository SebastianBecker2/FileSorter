namespace FileSorter
{
    partial class AssignDestination
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOkay = new System.Windows.Forms.Button();
            this.DgvDestinations = new System.Windows.Forms.DataGridView();
            this.dgcKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDestinations)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(453, 561);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOkay
            // 
            this.BtnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOkay.Location = new System.Drawing.Point(372, 561);
            this.BtnOkay.Name = "BtnOkay";
            this.BtnOkay.Size = new System.Drawing.Size(75, 23);
            this.BtnOkay.TabIndex = 12;
            this.BtnOkay.Text = "OK";
            this.BtnOkay.UseVisualStyleBackColor = true;
            this.BtnOkay.Click += new System.EventHandler(this.BtnOkay_Click);
            // 
            // DgvDestinations
            // 
            this.DgvDestinations.AllowUserToAddRows = false;
            this.DgvDestinations.AllowUserToDeleteRows = false;
            this.DgvDestinations.AllowUserToResizeColumns = false;
            this.DgvDestinations.AllowUserToResizeRows = false;
            this.DgvDestinations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDestinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDestinations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcKey,
            this.dgcPath});
            this.DgvDestinations.Location = new System.Drawing.Point(12, 12);
            this.DgvDestinations.MultiSelect = false;
            this.DgvDestinations.Name = "DgvDestinations";
            this.DgvDestinations.RowHeadersVisible = false;
            this.DgvDestinations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDestinations.Size = new System.Drawing.Size(516, 543);
            this.DgvDestinations.TabIndex = 14;
            // 
            // dgcKey
            // 
            this.dgcKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcKey.HeaderText = "Key";
            this.dgcKey.Name = "dgcKey";
            this.dgcKey.ReadOnly = true;
            this.dgcKey.Width = 50;
            // 
            // dgcPath
            // 
            this.dgcPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcPath.HeaderText = "Path";
            this.dgcPath.Name = "dgcPath";
            this.dgcPath.ReadOnly = true;
            // 
            // AssignDestination
            // 
            this.AcceptButton = this.BtnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(540, 596);
            this.Controls.Add(this.DgvDestinations);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOkay);
            this.Name = "AssignDestination";
            this.Text = "Assign Destination";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDestinations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOkay;
        private System.Windows.Forms.DataGridView DgvDestinations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPath;
    }
}