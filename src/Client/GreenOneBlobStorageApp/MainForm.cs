using GreenOneBlobStorage.Common;
using GreenOneBlobStorage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenOneBlobStorageApp
{
    public partial class MainForm : Form
    {
        private BindingList<Document> _bindingListDocuments = new BindingList<Document>();
        private readonly FileService _fileService = new FileService();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvDocuments_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void dgvDocuments_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string file in (Array)e.Data.GetData(DataFormats.FileDrop))
            {
                _bindingListDocuments.Add(new Document() { Id = Guid.NewGuid(),
                 Extension = _fileService.GetFileExtension(file),
                 Name = _fileService.GetFileNameOnly(file),
                Bytes = _fileService.ConvertToBytes(file),
                 Type = string.Empty});
            }
            this.BindDgvDocumentsGrid();
        }

        private void BindDgvDocumentsGrid()
        {
            bsDocuments.DataSource = _bindingListDocuments;
            bsDocuments.ResetBindings(false);
            _bindingListDocuments.AllowEdit = true;
        }
    }
}
