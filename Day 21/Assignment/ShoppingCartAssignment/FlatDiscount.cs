using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAssignment
{
    internal class FlatDiscount : IDiscount
    {
        public double Discount(double totalPrice)
        {
            return totalPrice = totalPrice - 200;
        }
    }
}
