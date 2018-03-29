using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GreenOneBlobStorage.Common
{
    [DataContract]
    public class Document
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string  Extension { get; set; }
        [DataMember]
        public byte[] Bytes { get; set; }
    }
}
