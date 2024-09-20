using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    public class Product
    {
        public string Name { get; set; }
        public double BasePrice { get; set; }
        public virtual int Count { get; set; } = 1;
        protected Product(string name, double price)
        {
            Name = name;
            BasePrice = price;
        }
        public virtual double GetPrice()
        {
            return BasePrice;
        }
    }
}
