namespace Allup.ViewModels
{
    public class BasketViewModel
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public string ImageUrl { get; set; }

        public int Count { get; set; } = 1;
    }
}

