using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cc = new CreditCard();

            Console.WriteLine("Enter the card number :");
            cc.CardNumber = int.Parse( Console.ReadLine());

            Console.WriteLine("Enter the expiry :");
            cc.Expiry = Console.ReadLine();

            Console.WriteLine("Enter the card CVC :");
            cc.CVC = int.Parse(Console.ReadLine());

            Console.WriteLine(cc);
        }
    }
}
