using GreenOneBlobStorage.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GreenOneBlobStorageService.Domain
{
    [DataContract]
    public class DocumentServicePostRequest
    {
        [DataMember]
        public List<Document> Documents { get; set; }
    }
}
