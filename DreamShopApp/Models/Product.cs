namespace DreamShopApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set;}
        public double Price { get; set;}
        public string Description { get; set; } = string.Empty;
        public int Rate { get; set;}
        // REVIEW RELATION
        public ICollection<Review> Reviews { get; set; } = new List<Review>();  
        // CATEGORY RELATION
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        // OWNER RELATION
        public int? OwnerId { get; set; }
        public Owner? Owner { get; set; }
        // ORDER RELATION
        public ICollection<ProductOrder> ProductOrders { get; set; } =new List<ProductOrder>();
    }
}
