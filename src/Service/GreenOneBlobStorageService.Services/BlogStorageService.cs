﻿using GreenOneBlobStorage.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GreenOneBlobStorageService.Services
{
    public class BlogStorageService
    {
        private readonly string _storageConnectionStringName;

        public BlogStorageService()
        {
            _storageConnectionStringName = ConfigurationManager.AppSettings["StorageConnectionStringName"].ToString();
        }

        public async Task<bool> AddDocumentsAsync(List<Document> documents)
        {
            bool task = false;
            var tasks = documents.Select(d => AddDocumentAsync(d));
            await Task.WhenAll(tasks);
            task = true;
            return task;
        }

        private async Task<bool> AddDocumentAsync(Document document)
        {
            bool task = false;
            CloudBlobContainer container = GetCloudBlobContainer(document.Type.ToLower());
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(document.Id.ToString());
            await blockBlob.UploadFromByteArrayAsync(document.Bytes, 0, document.Bytes.Length);
            task = true;

            return task;
        }

        public async Task<bool> DeleteDocumentAsync(List<Document> documents)
        {
            bool task = false;
            var tasks = documents.Select(d => DeleteDocumentAsync(d));
            await Task.WhenAll(tasks);
            task = true;
            return task;
        }

        private async Task<bool> DeleteDocumentAsync(Document document)
        {
            bool task = false;
            CloudBlobContainer container = GetCloudBlobContainer(document.Type.ToLower());
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(document.Id.ToString());
            await blockBlob.DeleteAsync();
            task = true;
            return task;
        }

        public async Task<Document> GetDocumentAsync(Document document)
        {
            CloudBlobContainer container = GetCloudBlobContainer(document.Type.ToLower());
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(document.Id.ToString());
            if (blockBlob != null)
            {
                blockBlob.FetchAttributes();
                long fileByteLength = blockBlob.Properties.Length;
                document.Bytes = new byte[fileByteLength];
                await blockBlob.DownloadToByteArrayAsync(document.Bytes, 0);
            }
            return document;
        }

        private CloudBlobContainer GetCloudBlobContainer(string containerName)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting(_storageConnectionStringName));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference(containerName);
            return blobContainer;
        }
    }
}
