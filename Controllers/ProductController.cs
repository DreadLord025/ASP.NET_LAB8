using Microsoft.AspNetCore.Mvc;
using Product.Models;

namespace Product.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var products = new List<ProductModel>
            {
                new ProductModel { ID = 1, Name = "Холодильник", Price = 7999, CreatedDate = DateTime.Now},
                new ProductModel { ID = 2, Name = "Шафа", Price = 1199, CreatedDate = DateTime.Now },
                new ProductModel { ID = 3, Name = "Ялинка", Price = 799, CreatedDate = DateTime.Now }
            };

            return View(products);
        }
    }
}
