using demoprojectAPI.Models;
using demoprojectAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace demoprojectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly DemoProjectAPIService _demoProjectAPIService;

        public DocumentController(DemoProjectAPIService demoProjectAPIService) =>
            _demoProjectAPIService = demoProjectAPIService;

        [HttpGet]
        [Route("SearchDocument/{keyword}/{searchby}")]
        public IActionResult SearchDocument(string keyword, string searchby)
        {
            var result =  _demoProjectAPIService.GetSearchData(searchby, keyword).Result;
            return Ok(result);  
        }

        [HttpGet]
        [Route("SearchDocument")]
        public async Task<List<Document>> Get() =>
            await _demoProjectAPIService.GetAsync();


    }
}
