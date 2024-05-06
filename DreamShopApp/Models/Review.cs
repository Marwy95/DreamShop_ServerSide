namespace DreamShopApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
