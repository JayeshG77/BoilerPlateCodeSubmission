using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Session2.Models;
using Session2.ModeView;
using Session2.Service;

namespace Session2.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductService _productService;
        readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;  
            _mapper = mapper;
        }
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult<List<Product>> ShowProducts()
        {
            List<Product> products = _productService.ShowProducts();
            return View(products);
            //List<Product> allProducts = _productService.ShowProducts();
            //var records = _mapper.Map<List<ShowProductVm>>(allProducts);
            //return View(records);

        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.AddProduct (product);
            return RedirectToAction("ShowProducts");
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var product=_productService.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            _productService.EditProduct(product);
            return RedirectToAction("ShowProducts");
        }

        [HttpGet]
        public IActionResult GetProductById(int id) 
        {
            var product =_productService.GetProductById(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteProduct(Product product)
        {
            _productService.DeleteProduct(product);
            return RedirectToAction("ShowProducts");
        }



    }
}
