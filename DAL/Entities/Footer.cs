namespace Allup.DAL.Entities
{
    public class Footer
    {
        public int Id { get; set; }
        public string Copyright { get; set; }
        public string CoprightLink { get; set; }
        public string PaymentMethod { get; set; }
        public string BgImageUrl { get; set; }
        public ICollection<AboutUs> AboutUses { get; set; }
        public ICollection<ContactDetail> ContactDetails { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Information> Informations { get; set; }
        public ICollection<MyAccount> MyAccounts { get; set; }
        public ICollection<NewLetter> NewLetters { get; set; }



    }
}
