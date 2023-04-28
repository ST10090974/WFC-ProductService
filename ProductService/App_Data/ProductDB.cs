using System.Collections.Generic;

namespace ProductService.Models
{
    public static class ProductDB
    {
        public static List<Product> Products { get; set; } = new List<Product> 
        {
            new Product("P321","Honey", 27.99),
            new Product("P322","Milk", 32.34),
            new Product("P323","Eggs", 76.87),
            new Product("P324","Meat", 56.65),
            new Product("P325","Tea", 32.23)
        };
    }
}
