namespace Allup.DAL.Entities
{
    public class ContactDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OpenTime { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }


    }
}
