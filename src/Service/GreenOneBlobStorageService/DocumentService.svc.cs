using GreenOneBlobStorage.Common;
using GreenOneBlobStorageService.Domain;
using System.Threading.Tasks;

namespace GreenOneBlobStorageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DocumentService : IDocumentService
    {
        public async Task<DocumentServiceDeleteResponse> DeleteAsync(DocumentServiceDeleteRequest request)
        {
            return await Task.Factory.StartNew(() => new DocumentServiceDeleteResponse());
        }

        public async Task<Document> GetAsync(Document document)
        {
            return await Task.Factory.StartNew(() => new Document());
        }

        public async Task<DocumentServicePostResponse> PostAsync(DocumentServicePostRequest request)
        {
            return await Task.Factory.StartNew(() => new DocumentServicePostResponse());
        }
    }
}
