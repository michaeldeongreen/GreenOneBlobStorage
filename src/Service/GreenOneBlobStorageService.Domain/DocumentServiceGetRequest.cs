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
    public class DocumentServiceGetRequest
    {
        [DataMember]
        public Document Document { get; set; }
    }
}
