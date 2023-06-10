namespace Allup.DAL.Entities
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public BrandAndFeature BrandAndFeature { get; set; }
    }
}
