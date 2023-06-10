namespace Allup.DAL.Entities
{
    public class NewLetter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BgImgUrl { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }

    }
}
