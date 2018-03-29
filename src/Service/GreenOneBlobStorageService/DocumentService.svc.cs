using GreenOneBlobStorage.Common;
using GreenOneBlobStorageService.Domain;
using GreenOneBlobStorageService.Services;
using System.Threading.Tasks;
using System.Linq;

namespace GreenOneBlobStorageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DocumentService : IDocumentService
    {
        private readonly BlogStorageService _blogStorageService;
        public DocumentService()
        {
            _blogStorageService = new BlogStorageService();
        }
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
            DocumentServicePostResponse response = new DocumentServicePostResponse();
            try
            {
                await _blogStorageService.AddDocumentsAsync(request.Documents);
                response.Documents = request.Documents.Select(d => d.Id).ToArray();
            }
            catch (System.Exception ex)
            {
                response = new DocumentServicePostResponse() { Error = ex.Message };
            }
            return response;
        }
    }
}
