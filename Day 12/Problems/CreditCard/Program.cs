using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ccManager = new CreditCardManager();

            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var card = GetCardData();
                        ccManager.Add(card);
                        break;
                    case "2":
                        Console.Write("Enter the number to search: ");
                        var cardNumber = Console.ReadLine();
                        ccManager.Search(cardNumber);
                        break;
                    case "3":
                        Console.Write("Enter the number to update: ");
                        var cardNumberUpdate = Console.ReadLine();
                        var updateCard = GetCardData();
                        ccManager.Update(updateCard,cardNumberUpdate);
                        break;
                        
                    case "4":
                        Console.Write("Enter the number to delete");
                        var cardNumberDelete = Console.ReadLine();
                        ccManager.Delete(cardNumberDelete);
                        break;
                }
            }
        }

        private static CreditCard GetCardData()
        {
            CreditCard card = new CreditCard();

            Console.Write("Enter the card holder name: ");
            card.CardHolderName = Console.ReadLine();

            Console.Write("Enter the card number: ");
            card.CardNumber = Console.ReadLine();

            Console.Write("Enter the card expiry date: ");
            card.Expiry = Console.ReadLine();

            Console.Write("Enter the security number: ");
            card.SecurityCode = int.Parse(Console.ReadLine());
            return card;
        }
    }
    
}
