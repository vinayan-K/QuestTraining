using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
       static List<CreditCard> CreditCards = new List<CreditCard>();
        static void AddCard()
        {
          
            var cc = new CreditCard();

            Console.WriteLine("Enter the card number :");
            cc.CardNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the card holder name :");
            cc.CardName = Console.ReadLine();

            Console.WriteLine("Enter the expiry month:");
            cc.ExpiryMonth = byte.Parse( Console.ReadLine()) ;

            Console.WriteLine("Enter the expiry year:");
            cc.ExpiryYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the card CVC :");
            cc.CVC = int.Parse(Console.ReadLine());

            CreditCards.Add(cc);
            Console.WriteLine("Card details added successfully");

        }

        static void SearchCaardByNumber()
        {
            Console.WriteLine("Enter card number for search : ");
            var searchNumber = int.Parse(Console.ReadLine());
            bool found = false;
            foreach (var cc in CreditCards)
            {
                if (searchNumber == cc.CardNumber)
                {
                    Console.WriteLine($"Name : {cc.CardName}");
                    Console.WriteLine($"Card Numer : {cc.CardNumber}");
                    Console.WriteLine($"Expiry : {cc.ExpiryMonth} / {cc.ExpiryYear}");
                    Console.WriteLine($"CVC : {cc.CVC}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Card Not Found");
            }
        }

        static void UpdateCardDetails()
        {
            Console.WriteLine("Enter Card Number");
            var cardNumber = int.Parse(Console.ReadLine());
            bool found = false;
            foreach (var cc in CreditCards)
            {
                if (cardNumber == cc.CardNumber)
                {
                    Console.WriteLine("Enter new card name:");
                    cc.CardName = Console.ReadLine();
                    Console.WriteLine("Enter new expiry month:");
                    cc.ExpiryMonth = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Enter new expiry year:");
                    cc.ExpiryYear = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter new cvc :");
                    cc.CVC = int.Parse(Console.ReadLine());
                    found = true;
                    break;                   
                }
            }
            if (!found)
            {
                Console.WriteLine("Card Not Found");
            }

        }

        static void DeleteCard()
        {
            Console.WriteLine("Enter the card number : ");
            var cardNumber = int.Parse(Console.ReadLine());
            bool found = false;
            foreach (var cc in CreditCards)
            {
                if (cardNumber == cc.CardNumber)
                {
                   CreditCards.Remove(cc);
                   Console.WriteLine("card deatils deleted successfully");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Card Not Found");
            }

        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add a card");
                Console.WriteLine("2.Search a card by card number");
                Console.WriteLine("3.Update a card details");
                Console.WriteLine("4.Delete a card");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddCard();
                        break;
                    case "2":
                        SearchCaardByNumber();
                        break;
                    case "3":
                        UpdateCardDetails();
                        break;
                    case "4":
                        DeleteCard();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }

        }
    }
}
