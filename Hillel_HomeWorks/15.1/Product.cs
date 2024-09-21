using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    public class Product
    {

        private double basePrice;
        public string GetProductName()
        {
            return GetType().Name;
        }
        public double BasePrice 
        {
            get { return basePrice; }
        }
        public virtual int Count { get; set; } = 1;
        protected Product(double price)
        {
            basePrice = price;
        }
        public virtual double GetPrice()
        {
            return BasePrice;
        }
    }
}
