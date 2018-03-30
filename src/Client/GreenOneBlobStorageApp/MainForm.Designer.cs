namespace GreenOneBlobStorageApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUploadAll = new System.Windows.Forms.Button();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bytesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Download = new System.Windows.Forms.DataGridViewImageColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.bsDocuments = new System.Windows.Forms.BindingSource(this.components);
            this.gbScreen.SuspendLayout();
            this.gbButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.gbButtons);
            this.gbScreen.Controls.Add(this.dgvDocuments);
            this.gbScreen.Location = new System.Drawing.Point(12, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(733, 485);
            this.gbScreen.TabIndex = 0;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "Drag N Drop Documents";
            // 
            // gbButtons
            // 
            this.gbButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbButtons.Controls.Add(this.lblTimer);
            this.gbButtons.Controls.Add(this.btnDelete);
            this.gbButtons.Controls.Add(this.btnUploadAll);
            this.gbButtons.Location = new System.Drawing.Point(6, 419);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(712, 48);
            this.gbButtons.TabIndex = 1;
            this.gbButtons.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(6, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(43, 13);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "lblTimer";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(601, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete All";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUploadAll
            // 
            this.btnUploadAll.Location = new System.Drawing.Point(493, 10);
            this.btnUploadAll.Name = "btnUploadAll";
            this.btnUploadAll.Size = new System.Drawing.Size(102, 32);
            this.btnUploadAll.TabIndex = 0;
            this.btnUploadAll.Text = "Upload All";
            this.btnUploadAll.UseVisualStyleBackColor = true;
            this.btnUploadAll.Click += new System.EventHandler(this.btnUploadAll_Click);
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowDrop = true;
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AllowUserToDeleteRows = false;
            this.dgvDocuments.AutoGenerateColumns = false;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn,
            this.bytesDataGridViewImageColumn,
            this.Download,
            this.Remove});
            this.dgvDocuments.DataSource = this.bsDocuments;
            this.dgvDocuments.Location = new System.Drawing.Point(3, 16);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.Size = new System.Drawing.Size(715, 397);
            this.dgvDocuments.TabIndex = 0;
            this.dgvDocuments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocuments_CellDoubleClick);
            this.dgvDocuments.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvDocuments_DragDrop);
            this.dgvDocuments.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvDocuments_DragEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Application";
            this.typeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "CEM",
            "CUDL3",
            "CUDL4"});
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            this.extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
            this.extensionDataGridViewTextBoxColumn.HeaderText = "Extension";
            this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            // 
            // bytesDataGridViewImageColumn
            // 
            this.bytesDataGridViewImageColumn.DataPropertyName = "Bytes";
            this.bytesDataGridViewImageColumn.HeaderText = "Bytes";
            this.bytesDataGridViewImageColumn.Name = "bytesDataGridViewImageColumn";
            this.bytesDataGridViewImageColumn.Visible = false;
            // 
            // Download
            // 
            this.Download.HeaderText = "Download";
            this.Download.Image = global::GreenOneBlobStorageApp.Properties.Resources.download;
            this.Download.Name = "Download";
            this.Download.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remove.HeaderText = "Remove";
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.Name = "Remove";
            // 
            // bsDocuments
            // 
            this.bsDocuments.DataSource = typeof(GreenOneBlobStorage.Common.Document);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 509);
            this.Controls.Add(this.gbScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocRep Azure - Proof of Concept";
            this.gbScreen.ResumeLayout(false);
            this.gbButtons.ResumeLayout(false);
            this.gbButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocuments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.BindingSource bsDocuments;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btnUploadAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn bytesDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn Download;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
    }
}

