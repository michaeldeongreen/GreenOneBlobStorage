﻿using GreenOneBlobStorage.Common;
using GreenOneBlobStorage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GreenOneBlobStorageApp
{
    public partial class MainForm : Form
    {
        private BindingList<Document> _bindingListDocuments = new BindingList<Document>();
        private readonly FileService _fileService = new FileService();
        private readonly Proxy _proxy = new Proxy();
        private const int _downloadColumn = 5;
        private const int _removeColumn = 6;

        public MainForm()
        {
            InitializeComponent();
            ClearLblTimer();
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
            BindDgvDocumentsGrid();
        }

        private void BindDgvDocumentsGrid()
        {
            bsDocuments.DataSource = _bindingListDocuments;
            bsDocuments.ResetBindings(false);
            _bindingListDocuments.AllowEdit = true;
        }

        private async void btnUploadAll_Click(object sender, EventArgs e)
        {
            if (_bindingListDocuments.Count() == 0 || _bindingListDocuments.Where(d => d.IsUploaded == false).Count() == 0) return;

            ScreenEnabled(false);
            ClearLblTimer();

            var documents = new List<Document>();
            documents.AddRange(_bindingListDocuments.Where(d => d.IsUploaded == false));

            var stopwatch = GetAndStartStopwatch();
            var response = await _proxy.PostAsync(documents);
            stopwatch.Stop();
            SetLblTimer(stopwatch);

            documents.ForEach(d => d.IsUploaded = true);
            ScreenEnabled(true);
        }

        private void ScreenEnabled(bool enabled)
        {
            if (enabled)
                Cursor = Cursors.Default;
            else
                Cursor = Cursors.WaitCursor;

            gbScreen.Enabled = enabled;
        }

        private Stopwatch GetAndStartStopwatch()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            return stopwatch;
        }

        private void ClearLblTimer()
        {
            lblTimer.Text = string.Empty;
        }

        private void SetLblTimer(Stopwatch stopwatch)
        {
            TimeSpan timeSpan = stopwatch.Elapsed;
            string elapsedTime = String.Format("Elasped Time (HH:MM:SS:MS): {0:00}:{1:00}:{2:00}.{3:00}",
            timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,
            timeSpan.Milliseconds / 10);
            lblTimer.Text = elapsedTime;
        }

        private async void dgvDocuments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var id = dgvDocuments.Rows[e.RowIndex].Cells[0].Value;
            Document selectedDocument = _bindingListDocuments.SingleOrDefault(d => d.Id.ToString() == id.ToString());

            if (e.ColumnIndex == _removeColumn)
            {
                bool task = await DeleteDocumentAsync(selectedDocument);
            }
        }

        private async Task<bool> DeleteDocumentAsync(Document document)
        {
            ScreenEnabled(false);
            ClearLblTimer();

            var documents = new List<Document>();
            documents.Add(document);

            var stopwatch = GetAndStartStopwatch();
            var response = await _proxy.DeleteAsync(documents);
            stopwatch.Stop();
            SetLblTimer(stopwatch);

            _bindingListDocuments.Remove(document);
            ScreenEnabled(true);

            return true;
        }
    }
}
