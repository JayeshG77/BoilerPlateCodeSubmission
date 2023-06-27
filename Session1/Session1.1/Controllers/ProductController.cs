using Microsoft.AspNetCore.Mvc;
using Session1.Service;

namespace Session1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyController : ControllerBase
    {
        private readonly IProductService _productService;

        public MyController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            string value = _productService.GetValue();
            return Ok(value);
        }
    }

}
