using Allup.DAL.Entities;

namespace Allup.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider>?Sliders { get; set; }
        public List<Banner>? Bans { get; set; }
        public List<Category>? Categories { get; set; }
        public List<Testimonial>? Testimonials { get; set;}
        public List<Blog>? Blogs { get; set; }
        public List<Product>? Products { get; set; }
        public List<Visitor>? Visitors { get; set; }
    }

}
