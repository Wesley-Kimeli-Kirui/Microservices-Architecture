﻿namespace TheJitu_Commerce_Cart.Model.Dto
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;


        public double Price { get; set; }

        public string CategoryName { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    
}
}
