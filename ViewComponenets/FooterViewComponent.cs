using Allup.DAL;
using Allup.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Allup.ViewComponenets
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footer = await _dbContext.Footers.Include(x => x.AboutUses).Include(x => x.ContactDetails).Include(x => x.Customers).Include(x => x.Informations).Include(x => x.MyAccounts).Include(x => x.NewLetters).FirstOrDefaultAsync();

            return View(footer);
        }
    }
}
