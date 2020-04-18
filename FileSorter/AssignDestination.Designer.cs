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
            this.components = new System.ComponentModel.Container();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOkay = new System.Windows.Forms.Button();
            this.DgvDestinations = new System.Windows.Forms.DataGridView();
            this.dgcKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvRecentDestinations = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.LblFileName = new System.Windows.Forms.Label();
            this.TipFileName = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDestinations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecentDestinations)).BeginInit();
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
            this.DgvDestinations.Location = new System.Drawing.Point(12, 65);
            this.DgvDestinations.MultiSelect = false;
            this.DgvDestinations.Name = "DgvDestinations";
            this.DgvDestinations.RowHeadersVisible = false;
            this.DgvDestinations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDestinations.Size = new System.Drawing.Size(516, 290);
            this.DgvDestinations.TabIndex = 14;
            this.DgvDestinations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDestinations_CellDoubleClick);
            this.DgvDestinations.SelectionChanged += new System.EventHandler(this.DgvDestinations_SelectionChanged);
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
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(50, 39);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(478, 20);
            this.TxtFilter.TabIndex = 15;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Filter:";
            // 
            // DgvRecentDestinations
            // 
            this.DgvRecentDestinations.AllowUserToAddRows = false;
            this.DgvRecentDestinations.AllowUserToDeleteRows = false;
            this.DgvRecentDestinations.AllowUserToResizeColumns = false;
            this.DgvRecentDestinations.AllowUserToResizeRows = false;
            this.DgvRecentDestinations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRecentDestinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecentDestinations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DgvRecentDestinations.Location = new System.Drawing.Point(12, 374);
            this.DgvRecentDestinations.MultiSelect = false;
            this.DgvRecentDestinations.Name = "DgvRecentDestinations";
            this.DgvRecentDestinations.RowHeadersVisible = false;
            this.DgvRecentDestinations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRecentDestinations.Size = new System.Drawing.Size(516, 181);
            this.DgvRecentDestinations.TabIndex = 17;
            this.DgvRecentDestinations.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvRecentDestinations_CellMouseDoubleClick);
            this.DgvRecentDestinations.SelectionChanged += new System.EventHandler(this.DgvRecentDestinations_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Key";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Path";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Recently selected:";
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(12, 9);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(57, 13);
            this.LblFileName.TabIndex = 19;
            this.LblFileName.Text = "Assign file:";
            // 
            // AssignDestination
            // 
            this.AcceptButton = this.BtnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(540, 596);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvRecentDestinations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.DgvDestinations);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOkay);
            this.Name = "AssignDestination";
            this.Text = "Assign Destination";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDestinations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecentDestinations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOkay;
        private System.Windows.Forms.DataGridView DgvDestinations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPath;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvRecentDestinations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.ToolTip TipFileName;
    }
}