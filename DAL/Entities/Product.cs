using Allup.DAL.Entities;

namespace Allup.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string? Price { get; set; }
        public string? OLdPrice { get; set; }
        public string? Discount { get; set; }
        public int Stock { get; set; }
        public string FirstImageUrl { get; set; }
        public string? SecondImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
