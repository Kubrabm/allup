using Allup.DAL;
using Allup.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Allup.ViewComponenets
{
    public class BrandAndFeatureViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public BrandAndFeatureViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var brbrandandfeatureand = await _dbContext.BrandAndFeatures.Include(x => x.BrandLists).Include(x => x.Features).FirstOrDefaultAsync();
                

            return View(brbrandandfeatureand);
        }
    }
}
