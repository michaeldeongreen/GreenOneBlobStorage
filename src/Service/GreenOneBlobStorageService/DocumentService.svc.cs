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
            DocumentServiceDeleteResponse response = new DocumentServiceDeleteResponse();
            try
            {
                await _blogStorageService.DeleteDocumentAsync(request.Documents);
                response.Documents = request.Documents.Select(d => d.Id).ToArray();
            }
            catch (System.Exception ex)
            {
                response = new DocumentServiceDeleteResponse() { Error = ex.Message };
            }
            return response;
        }

        public async Task<DocumentServiceGetResponse> GetAsync(DocumentServiceGetRequest request)
        {
            DocumentServiceGetResponse response = new DocumentServiceGetResponse();
            try
            {
                response.Document = await _blogStorageService.GetDocumentAsync(request.Document);
            }
            catch (System.Exception ex)
            {
                response = new DocumentServiceGetResponse() { Error = ex.Message };
            }
            return response;
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
