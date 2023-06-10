using Allup.DAL.Entities;

namespace Allup.DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Bacground { get; set; }
        public int OptionValue { get; set; }
        public Category ParentCategory { get; set; }
        public bool IsMain { get; set; }
    }
}
