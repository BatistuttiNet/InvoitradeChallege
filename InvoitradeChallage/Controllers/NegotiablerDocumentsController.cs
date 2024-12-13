using Microsoft.AspNetCore.Mvc;

namespace InvoitradeChallage.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NegotiablerDocumentsController : ControllerBase
    {
        public NegotiablerDocumentsController()
        {
        }

        [HttpGet(Name = "GetNegotableDocument")]
        public NegotiableDocument Get()
        {
           var service = new NegotiableDocumentService();

           return service.CreateNegotiableDocument(new NegotiableDocument());
        }
    }
}
