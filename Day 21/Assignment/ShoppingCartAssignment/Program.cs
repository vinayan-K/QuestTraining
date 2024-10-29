using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            cart.AddItem(new CartItem("Milk", 4, 50));
            cart.AddItem(new CartItem("Egg", 5, 5));
            cart.AddItem(new CartItem("Bread", 3, 90));
            cart.AddItem(new CartItem("Rice", 8, 80));

            Console.WriteLine($"Total Amount : " + cart.TotalAmount());
            
            var discountPercentage = 15.4 ;
            cart.DiscountMethod(new PercentageDiscount(discountPercentage));
            Console.WriteLine($"Discounted price ({discountPercentage}% discount) : " + cart.TotalAmount());
        }
    }
}
