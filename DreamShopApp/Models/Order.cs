namespace DreamShopApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
