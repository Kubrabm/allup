using Allup.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace Allup.DAL
{
    public class AppDbContext:DbContext
    {
        internal readonly object Information;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<AboutUs> AboutUses { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Information> InformationDetails { get; set; }
        public DbSet<MyAccount> MyAccounts { get; set; }
        public DbSet<NewLetter> NewLetters { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Banner> Bans { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;}
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Value> Values { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Nav> Navs { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<BrandList> BrandLists { get; set; }
        public DbSet<BrandAndFeature> BrandAndFeatures { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public object ContactUs { get; internal set; }
    }
}
