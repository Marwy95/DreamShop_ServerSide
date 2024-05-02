namespace DreamShopApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set;}
        public double Price { get; set;}
        public string Description { get; set; }
        public int Rate { get; set;}
        public ICollection<Review> Reviews { get; set; }
        public Category Category { get; set; }
        public Owner Owner { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
        // public ICollection<Category> Categories { get; set; }
    }
}
