namespace Allup.DAL.Entities
{
    public class BrandAndFeature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BrandList> BrandLists { get; set; }
        public ICollection<Feature> Features { get; set; }


    }
}
