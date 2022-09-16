using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using Newtonsoft.Json;
using System;

namespace MvcWebUI.Controllers
{
    public class ProductController:Controller
    {
        IProductServices _productService;

        public ProductController(IProductServices productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int category)
        {
            var model = new ProductListViewModel
            {
                Products = category>0?_productService.GetByCategory(category): _productService.GetAll()
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult NewProduct()
        {
            return PartialView("NewProduct", new Models.ProductListViewModel { Products=_productService.GetAll()});
        }

        [HttpPost]
        public IActionResult NewProduct(Product product)
        {
             _productService.Add(product);
             var jsonProduct = JsonConvert.SerializeObject(product);
             return Json(jsonProduct);
        }
   
        [HttpPost]
        public IActionResult RemoveProduct(int? id)
        {
            Product product=_productService.GetById(id);
            _productService.Delete(product);
            return Json(product);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            var product = _productService.GetById(p.ProductId);
            _productService.Update(product);
            var jsonproduct = JsonConvert.SerializeObject(product);
            return Json(jsonproduct);
        }
    }
}
