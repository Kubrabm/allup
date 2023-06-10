using Allup.DAL;
using Allup.DAL.Entities;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Allup.Contollers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ContactController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var contactus = _dbContext?.ContactUses.ToList();


            var viewModel = new ContactViewModel
            {
                ContactUses = contactus,
            };

            return View(viewModel);
        }
    }
}

