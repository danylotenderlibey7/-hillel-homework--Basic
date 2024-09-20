using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    public class Shop
    {
        private List<Product> products = new List<Product>();
        public void AddProduct(List<Product> new_products)
        {
            products.AddRange(new_products);
        }

        public void ProductInfo()
        {
            double totalPrice = 0;
            foreach(var item in products)
            {
                Console.Write($"Product: {item.Name}, Price: {item.BasePrice}");
                if (item.Count > 1)
                {
                    Console.Write($", Count: {item.Count}, Total price: {item.GetPrice()}");
                }
                totalPrice += item.GetPrice();
                Console.WriteLine();
            }

            Console.WriteLine($"Total products price: {totalPrice}");
        }
    }
}
