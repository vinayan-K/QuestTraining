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

            var discountPercentage = 15.4 ;            
            var billingService = new BillingService(new PercentageDiscount(discountPercentage));            
            Console.WriteLine($"Discounted price ({discountPercentage}% discount) : " + billingService.TotalAmount(cart.GetAll()));

            var billing = new BillingService(new FlatDiscount());
            Console.WriteLine("Total Amount : " + billing.TotalAmount(cart.GetAll()));
        }
    }
}
