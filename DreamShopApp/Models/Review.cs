﻿namespace DreamShopApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
