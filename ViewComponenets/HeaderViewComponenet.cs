using Allup.DAL;
using Allup.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Allup.ViewComponenets
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public HeaderViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var header = await _dbContext.Headers.Include(x => x.Languages).Include(x => x.Settings).Include(x => x.Values).Include(x => x.Categories).Include(x => x.Navs).FirstOrDefaultAsync();

            return View(header);
        }
    }
}
