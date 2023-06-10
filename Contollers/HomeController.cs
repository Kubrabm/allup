using Allup.DAL;
using Allup.DAL.Entities;
using Allup.Extensions;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {

            var slider = await _dbContext.Sliders.ToListAsync();
            var banner = await _dbContext.Bans.ToListAsync();
            var category = await _dbContext.Categories.ToListAsync();
            var product = await _dbContext.Products.Include(x => x.Category).ToListAsync();
            var blog = await _dbContext.Blogs.ToListAsync();
            var testimonial = await _dbContext.Testimonials.ToListAsync();
            var visitor = await _dbContext.Visitors.ToListAsync();

            var model = new HomeViewModel
            {
                Sliders = slider,
                Bans = banner,
                Categories = category,
                Products = product,
                Blogs = blog,
                Testimonials = testimonial,
                Visitors = visitor,

            };

            //HttpContext.Session.SetJson("visitors", visitor);

            return View(model);
        }

        public IActionResult Basket()
        {
            var json = Request.Cookies["basket"];

            List<BasketViewModel> basketViewModels;

            if (json == null) basketViewModels = new List<BasketViewModel>();
            else basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(json);

            return Json(basketViewModels);
        }

        public IActionResult AddToBasket(int? id)
        {
            if (id == null) return NotFound();

            var product = _dbContext.Products.Find(id);

            var json = Request.Cookies["basket"];
            List<BasketViewModel> basketViewModels;

            if (json == null) basketViewModels = new List<BasketViewModel>();
            else basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(json);

            if (basketViewModels == null)
            {
                basketViewModels = new List<BasketViewModel>();
                basketViewModels.Add(new BasketViewModel
                {
                    ProductId = product.Id,
                    Name = product.Name,
                });
            }
            else
            {
                var existBasketViewModel = basketViewModels.FirstOrDefault(x => x.ProductId == product.Id);

                if (existBasketViewModel == null)
                {
                    basketViewModels.Add(new BasketViewModel
                    {
                        ProductId = product.Id,
                        Name = product.Name,
                    });
                }

                else
                {
                    existBasketViewModel.Count++;
                }
            }

            json = JsonConvert.SerializeObject(basketViewModels);

            Response.Cookies.Append("basket", json);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Search(string searchedProduct)
        {
            var products = _dbContext.Products.Where(x => x.Name.Contains(searchedProduct)).ToList();

            return PartialView("_SearchedProductPartial", products);
        }

    }

}