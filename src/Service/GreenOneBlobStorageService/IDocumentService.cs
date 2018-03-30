using GreenOneBlobStorage.Common;
using GreenOneBlobStorageService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace GreenOneBlobStorageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDocumentService
    {
        [OperationContract]
        Task<DocumentServicePostResponse> PostAsync(DocumentServicePostRequest request);
        [OperationContract]
        Task<DocumentServiceGetResponse> GetAsync(DocumentServiceGetRequest request);
        [OperationContract]
        Task<DocumentServiceDeleteResponse> DeleteAsync(DocumentServiceDeleteRequest request);
    }
}
