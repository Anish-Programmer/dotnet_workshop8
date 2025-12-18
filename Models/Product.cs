namespace Workshop8.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Likes { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
