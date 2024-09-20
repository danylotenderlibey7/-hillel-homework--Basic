using System;
using System.Collections.Generic;
namespace _15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Carrot(15),
                new Potato(20, 4),
                new Cucumber(14, 2),
                //new Pepper(5)
            };

            Shop shop = new Shop();
            shop.AddProduct(products);
            shop.ProductInfo();
        }
    }
}
