using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GreenOneBlobStorageService.Domain
{
    [DataContract]
    public class DocumentServicePostResponse
    {
        [DataMember]
        public Guid[] Documents { get; set; }
        [DataMember]
        public string Error { get; set; }
    }
}
