using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAssignment
{
    internal class CartItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice => Quantity * Price;
        public CartItem(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
