namespace Allup.DAL.Entities
{
    public class MyAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}
