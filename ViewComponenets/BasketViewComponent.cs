using Allup.DAL;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Allup.ViewComponents
{
    public class BasketViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public BasketViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var json = Request.Cookies["basket"];

            List<BasketViewModel> basketViewModels;

            if (json == null) basketViewModels = new List<BasketViewModel>();
            else basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(json);

            return View(basketViewModels);
        }

    }
}
