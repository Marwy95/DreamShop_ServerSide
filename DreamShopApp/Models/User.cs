namespace DreamShopApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } =string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int UserName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } =string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
