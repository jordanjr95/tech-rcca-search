using demoprojectAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoprojectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private List<Document> documents = new List<Document>
        {
            new Document {
            ID = 1, documentID = 1, templateID = 1,
            documentReference = "https://rccastorage.blob.core.windows.net/rcca-container/Mocha4.jpeg",
            waitingforAdminApproval = true,
            contributor = "vraj", 
            creator = "jordan", 
            date = new DateTime(28/04/23), 
            description = "demo" },
            
            new Document {
            ID = 2, documentID = 2, templateID = 2,
            documentReference = "https://rccastorage.blob.core.windows.net/rcca-container/Mocha4.jpeg",
            waitingforAdminApproval = false,
            contributor = "vraj",
            creator = "jordan",
            date = new DateTime(29/04/23), 
            description = "test" },
            
            new Document {
            ID = 3, documentID = 3, templateID = 3,
            documentReference = "https://rccastorage.blob.core.windows.net/rcca-container/Mocha4.jpeg",
            waitingforAdminApproval = true,
            contributor = "hamish", 
            creator = "hamish",
            date = new DateTime(01/05/23),
            description = "rover" },

            new Document {
            ID = 4, documentID = 4, templateID = 4,
            documentReference = "https://rccastorage.blob.core.windows.net/rcca-container/Mocha4.jpeg",
            waitingforAdminApproval = true,
            contributor = "hamish jordan",
            creator = "hamish",
            date = new DateTime(01/05/23),
            description = "rover" },
        };
        [HttpGet]
        [Route("SearchDocument/{keyword}/{searchby}")]
        public IActionResult SearchDocument(string keyword, string searchby)
        {
            List<Document> result = new List<Document>();
            switch (searchby)
            {
                case "creator":
                    result = documents.Where(x => x.creator.Contains(keyword)).ToList();
                    break;

                case "contributor":
                    result = documents.Where(x => x.contributor.Contains(keyword)).ToList();
                    break;

                case "description":
                    result = documents.Where(x => x.description.Contains(keyword)).ToList();
                    break;
            }
            return Ok(result);
        }
    }
}
