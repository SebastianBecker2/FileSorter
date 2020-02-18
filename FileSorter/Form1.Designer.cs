namespace FileSorter
{
    partial class Form1
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
            this.DgvSortedFiles = new System.Windows.Forms.DataGridView();
            this.dgcSort = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgcFilteredKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDestinationPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSortFiles = new System.Windows.Forms.Button();
            this.BtnFindFiles = new System.Windows.Forms.Button();
            this.BtnShowConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSortedFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSortedFiles
            // 
            this.DgvSortedFiles.AllowUserToAddRows = false;
            this.DgvSortedFiles.AllowUserToDeleteRows = false;
            this.DgvSortedFiles.AllowUserToResizeRows = false;
            this.DgvSortedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSortedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSortedFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcSort,
            this.dgcFilteredKey,
            this.dgcFileName,
            this.dgcDestinationPath});
            this.DgvSortedFiles.Location = new System.Drawing.Point(12, 41);
            this.DgvSortedFiles.Name = "DgvSortedFiles";
            this.DgvSortedFiles.RowHeadersVisible = false;
            this.DgvSortedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSortedFiles.Size = new System.Drawing.Size(776, 368);
            this.DgvSortedFiles.TabIndex = 6;
            this.DgvSortedFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSortedFiles_CellDoubleClick);
            this.DgvSortedFiles.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvSortedFiles_CellMouseDown);
            this.DgvSortedFiles.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSortedFiles_CellValueChanged);
            this.DgvSortedFiles.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvSortedFiles_CurrentCellDirtyStateChanged);
            this.DgvSortedFiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvSortedFiles_KeyPress);
            // 
            // dgcSort
            // 
            this.dgcSort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgcSort.HeaderText = "Sort";
            this.dgcSort.Name = "dgcSort";
            this.dgcSort.Width = 32;
            // 
            // dgcFilteredKey
            // 
            this.dgcFilteredKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcFilteredKey.HeaderText = "Key";
            this.dgcFilteredKey.Name = "dgcFilteredKey";
            this.dgcFilteredKey.ReadOnly = true;
            this.dgcFilteredKey.Width = 50;
            // 
            // dgcFileName
            // 
            this.dgcFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcFileName.HeaderText = "FileName";
            this.dgcFileName.Name = "dgcFileName";
            this.dgcFileName.ReadOnly = true;
            this.dgcFileName.Width = 76;
            // 
            // dgcDestinationPath
            // 
            this.dgcDestinationPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcDestinationPath.HeaderText = "DestinationPath";
            this.dgcDestinationPath.Name = "dgcDestinationPath";
            this.dgcDestinationPath.ReadOnly = true;
            // 
            // BtnSortFiles
            // 
            this.BtnSortFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSortFiles.Location = new System.Drawing.Point(668, 415);
            this.BtnSortFiles.Name = "BtnSortFiles";
            this.BtnSortFiles.Size = new System.Drawing.Size(120, 23);
            this.BtnSortFiles.TabIndex = 7;
            this.BtnSortFiles.Text = "Sort Selected Files";
            this.BtnSortFiles.UseVisualStyleBackColor = true;
            this.BtnSortFiles.Click += new System.EventHandler(this.BtnSortFiles_Click);
            // 
            // BtnFindFiles
            // 
            this.BtnFindFiles.Location = new System.Drawing.Point(12, 12);
            this.BtnFindFiles.Name = "BtnFindFiles";
            this.BtnFindFiles.Size = new System.Drawing.Size(120, 23);
            this.BtnFindFiles.TabIndex = 8;
            this.BtnFindFiles.Text = "Find Files To Sort";
            this.BtnFindFiles.UseVisualStyleBackColor = true;
            this.BtnFindFiles.Click += new System.EventHandler(this.BtnFindFiles_Click);
            // 
            // BtnShowConfig
            // 
            this.BtnShowConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnShowConfig.Location = new System.Drawing.Point(668, 12);
            this.BtnShowConfig.Name = "BtnShowConfig";
            this.BtnShowConfig.Size = new System.Drawing.Size(120, 23);
            this.BtnShowConfig.TabIndex = 9;
            this.BtnShowConfig.Text = "Show Config";
            this.BtnShowConfig.UseVisualStyleBackColor = true;
            this.BtnShowConfig.Click += new System.EventHandler(this.BtnShowConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnShowConfig);
            this.Controls.Add(this.BtnFindFiles);
            this.Controls.Add(this.BtnSortFiles);
            this.Controls.Add(this.DgvSortedFiles);
            this.Name = "Form1";
            this.Text = "File Sorter";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSortedFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvSortedFiles;
        private System.Windows.Forms.Button BtnSortFiles;
        private System.Windows.Forms.Button BtnFindFiles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgcSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilteredKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDestinationPath;
        private System.Windows.Forms.Button BtnShowConfig;
    }
}

