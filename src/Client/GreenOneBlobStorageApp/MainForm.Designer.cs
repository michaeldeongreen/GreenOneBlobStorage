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
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.bsDocuments = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bytesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.dgvDocuments);
            this.gbScreen.Location = new System.Drawing.Point(23, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(806, 476);
            this.gbScreen.TabIndex = 0;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "Drag N Drop Documents";
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AutoGenerateColumns = false;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn,
            this.bytesDataGridViewImageColumn});
            this.dgvDocuments.DataSource = this.bsDocuments;
            this.dgvDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocuments.Location = new System.Drawing.Point(3, 16);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.Size = new System.Drawing.Size(800, 457);
            this.dgvDocuments.TabIndex = 0;
            // 
            // bsDocuments
            // 
            this.bsDocuments.DataSource = typeof(GreenOneBlobStorage.Common.Document);
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
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "CEM",
            "CUDL3",
            "CUDL4"});
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 509);
            this.Controls.Add(this.gbScreen);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocuments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.BindingSource bsDocuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn bytesDataGridViewImageColumn;
    }
}

