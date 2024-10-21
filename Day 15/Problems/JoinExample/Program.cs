using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinExample
{
    internal class Program
    {
        class Account
        {
            public int AccountId { get; set; }
            public string Name { get; set; }
            public double Balance { get; set; }
        }
        class Transaction
        {
            public int TransactionId { get; set; }
            public int FromAccountId { get; set; }
            public int ToAccountId { get; set; }
            public double Amount { get; set; }
            public DateTime DateTime { get; set; }
        }
        static void Main(string[] args)
        {
            var accounts = new List<Account>()
            {
                new Account{AccountId = 1, Name ="John", Balance = 1000},
                new Account{AccountId = 2, Name ="Mary", Balance = 2000},
                new Account{AccountId = 3, Name ="Jane", Balance = 3000},
            };
            var transactions = new List<Transaction>()
            {
                new Transaction{TransactionId = 1, FromAccountId = 1, ToAccountId = 2, Amount = 300, DateTime = DateTime.Now },
                 new Transaction{TransactionId = 2, FromAccountId = 2, ToAccountId = 3, Amount = 500, DateTime = DateTime.Now  },
            };
            var transactionDetails = transactions
                .Join(
                       accounts,
                       t => t.FromAccountId,
                       a => a.AccountId,
                       (transaction, account) => new { Transaction = transaction, FromAccount = account })
                .Join(
                       accounts,
                       res => res.Transaction.ToAccountId,
                       a => a.AccountId,
                       (res, toAccount) => new
                       {
                           TransactionId = res.Transaction.TransactionId,
                           FromAccountName = res.FromAccount.Name,
                           ToAccountName = toAccount.Name,
                           Amount = res.Transaction.Amount,
                           Date = res.Transaction.DateTime,
                       });

            foreach (var item in transactionDetails)
            {
                Console.WriteLine($"From :{item.FromAccountName}, To : {item.ToAccountName}, Amount : {item.Amount}, Date: {item.Date}");
            }

        }
    }
}
