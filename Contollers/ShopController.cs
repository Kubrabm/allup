using Allup.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Allup.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ShopController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var products = _dbContext.Products.Take(8).ToList();

            return View(products);
        }

    }
}
