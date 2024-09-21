using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    public class Potato : Product
    {
        public  override int Count { get; set; }
        public Potato(double basePrice, int count) : base(basePrice)
        {
            Count = count;
        }
        public override double GetPrice()
        {
            return BasePrice * Count; 
        }
    }

}
