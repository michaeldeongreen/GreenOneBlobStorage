﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenOneBlobStorageApp.DocumentServiceClient;
using GreenOneBlobStorage.Common;

namespace GreenOneBlobStorageApp
{
    public class Proxy
    {
        private readonly DocumentServiceClient.DocumentServiceClient _client;
        public Proxy()
        {
            _client = new DocumentServiceClient.DocumentServiceClient();
        }

        public async Task<DocumentServicePostResponse> PostAsync(List<Document> documents)
        {
            var request = new DocumentServicePostRequest() { Documents = documents };
            var response = await _client.PostAsync(request);

            return response;
        }
    }
}