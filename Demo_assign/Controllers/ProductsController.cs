using Demo_assign.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.Formatters;

namespace Demo_assign.Controllers
{
    public class ProductsController : Controller
    {
        //baseurl/products/test
        //public string Test()
        //  {
        //      return "Hello from Test";
        //  }
        //public IActionResult Test()
        //  {
        //ContentResult result = new ContentResult();
        //result.ContentType = "text/html";
        //result.StatusCode = StatusCodes.Status200OK;
        //result.Content = "Hello from Test <br/> bye bassant";
        //return result;
        //if(true)
        //{
        //    return Content(content: "Hello from Test <br/> bye bassant", contentType: "text/html");
        //}
        //else
        //{
        //    return NotFound();
        //}
        //}
        //[HttpGet]
        //public IActionResult Test()
        //{
        //    return View();
        //}
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<Product>()
            {
                new Product() { id = 1, Name = "Mobile" },
                new Product() { id = 2, Name = "mobile2" }

            };
            return Json(products);
        }
        //[NonAction]
        //public IActionResult Test()
        //{
        //    return View();
        //}
        //public IActionResult GetProductsById(int id)
        //{
        //    if (id < 0)

        //        return BadRequest();

        //    else if (id == 0)

        //        return RedirectToAction(nameof(GetProducts));
        //    else if (id < 10)
        //        return NotFound();
        //    else
        //        return Json(new Product() { id = id, Name = "Laptop" });

        //}
        //redirect to url
        //[HttpGet] 
        //public IActionResult RedirectAction()
        //{
        //    return Redirect("gemail.com");
        //}
        //[HttpGet("products/Test01")]
        //public IActionResult TestRouting()
        //{
        //    return Json($"hello from testrouting");
        //}
        //[HttpGet("TestRouting/Test{id:int}")]
        //public IActionResult TestRouting(int id)
        //{
        //    return Json($"hello from testrouting id: {id}");
        //}
        //public IActionResult TestRouting(int id,string name)
        //{
        //    return Json($"hello from testrouting id: {id}, name: {name}");
        //}
        //[HttpGet("json")]
        //public IActionResult JsonAction()
        //{
        //    return Json($"hello from json action");
        //}
        //[HttpGet("ProductCode/{code:int}")]
        //public IActionResult GetProductByCode(int code)
        //{
        //    return Json(new Product() { id = code, Name = "Mobile" });
        //}
        //[HttpGet ]
        //public IActionResult GetById([FromQuery] int id , int anotherId)
        //{
        //    return Json(new {id = id, anotherId = anotherId});
        //}
        //[HttpGet]
        //public IActionResult Search(ProductFilter filter)
        //{
        //    return Content("search completed");
        //}
        //collection
        //[HttpGet]
        //public IActionResult GetByIds(int[] ids)
        //{
        //    return Json (new
        //        {
        //             ids
        //        });
        //}
    }
}
