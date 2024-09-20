using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    public class Cucumber : Product
    {
        public override int Count { get;  set; }
        public Cucumber(double basePrice, int count) : base("Cucumber", basePrice)
        {
            Count = count;
        }
        public override double GetPrice()
        {
            return BasePrice * Count;
        }
    }
}
