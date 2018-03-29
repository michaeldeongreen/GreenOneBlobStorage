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
        private readonly Proxy _proxy = new Proxy();

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

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            if (_bindingListDocuments.Count() == 0 && _bindingListDocuments.Where(d => d.IsUploaded == false).Count() > 0) return;

            this.ScreenEnabled(false);
            var documents = new List<Document>();
            documents.AddRange(_bindingListDocuments.Where(d => d.IsUploaded == false));
            var response = await _proxy.PostAsync(documents);
            this.ScreenEnabled(false);
        }

        private void ScreenEnabled(bool enabled)
        {
            gbScreen.Enabled = enabled;
        }
    }
}
