using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAssignment
{
    internal interface IDiscount
    {
        double Discount(double totalPrice);
    }
}
