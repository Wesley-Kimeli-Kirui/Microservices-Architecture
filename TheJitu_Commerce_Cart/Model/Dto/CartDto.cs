﻿namespace TheJitu_Commerce_Cart.Model.Dto
{
    public class CartDto
    {
        public CartHeaderDto CartHeader { get; set; }   

        public IEnumerable<CartDetailsDto>? CartDetails { get; set; }
    }
}
