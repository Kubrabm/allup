using Allup.DAL.Entities;

namespace Allup.ViewModels
{
    public class HeaderViewModel
    {
        public List<Header> Headers { get; set; }
        public List<Category> Categories { get; set; }
        public List<ContactDetail> ContactDetails { get; set; }
        public List<BasketViewModel> BasketViewModels { get; set; }
    }
}
