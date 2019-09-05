using DellChallenge.D2.Web.Models;
using DellChallenge.D2.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DellChallenge.D2.Web.Controllers
{

    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _productService.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(NewProductModel newProduct)
        {
            if (!ModelState.IsValid)
                return View(newProduct);

                _productService.Add(newProduct);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteProductByIdAsync(int id)
        {
            var result = _productService.DeleteProductByIdAsync(id).Result;
            if (result)
                return RedirectToAction("Index");

            return Redirect("Error");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = _productService.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(int id, NewProductModel newProduct)
        {
            if (!ModelState.IsValid)
                return View(new ProductModel() { Id = id, Name = newProduct.Name, Category = newProduct.Category });

            var result = _productService.UpdateProduct(newProduct, id);
            if (result)
                return RedirectToAction("Index");

            return Redirect("Error");
        }
    }
}