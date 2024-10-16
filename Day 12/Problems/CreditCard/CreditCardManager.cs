using System;
using System.Collections.Generic;

namespace CreditCard
{
    /// <summary>
    /// This class is responsible for managing the credit cards.
    /// </summary>
    class CreditCardManager
    {
        private List<CreditCard> creditCards = new List<CreditCard>();

        /// <summary>
        /// This method adds a credit card. If a credit card already exists, it will not be added.
        /// </summary>
        /// <param name="card">An instance of <see cref="CreditCard"/>>.</param>
        public void Add(CreditCard card)
        {
            // Check if the same card exists.
            if (GetCardByNumber(card.CardNumber) != null)
            {
                Console.WriteLine("Card already exists");
                return;
            }

            creditCards.Add(card);
            Console.WriteLine("Added successfully");
        }

        /// <summary>
        /// This method searches for a credit card based on the card number.
        /// </summary>
        /// <param name="cardNumber">The credit card number.</param>
        public void Search(string cardNumber)
        {
            var card = GetCardByNumber(cardNumber);
            if (card == null)
            {
                Console.WriteLine("Card Not Found");
                return;
            }

            Console.WriteLine(card);
        }

        /// <summary>
        /// This method deletes a credit card based on the card number.
        /// </summary>
        /// <param name="card"></param>
        public void Delete(string cardNumberDelete)
        {
            var card = GetCardByNumber(cardNumberDelete);
            if (card == null)
            {
                Console.WriteLine("Card Not Found");
                return;
            }

            creditCards.Remove(card);
            Console.WriteLine("Deleted successfully");
            return;
        }

        /// <summary>
        /// This method updates card details based on the card number.
        /// </summary>
        /// <param name="card"></param>
        public void Update(CreditCard updatecard, string cardNumberUpdate)
        {
            var card = GetCardByNumber(cardNumberUpdate);
            if (card == null)
            {
                Console.WriteLine("Card Not Found");
                return;
            }

            card.CardHolderName = updatecard.CardHolderName;
            card.Expiry = updatecard.Expiry;
            card.SecurityCode = updatecard.SecurityCode;
            Console.WriteLine("Updated successfully");
        }

        /// <summary>
        /// This method is used to check if a card exists or not.
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns></returns>
        private CreditCard GetCardByNumber(string cardNumber)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    return card;
                }
            }

            return null;
        }
    }
}
