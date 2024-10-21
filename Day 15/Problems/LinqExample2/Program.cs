using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample2
{
    class Person
    {
        public string Name { get; set; }
        public string[] Emails { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            var data = new List<Person>()
            {
                new Person {Name = "Person1", Emails = new string[]{ "a@mail.com" ,"a@outlook.com" } },
                new Person { Name = "Person2",  Emails = new string[]{ "b@mail.com" ,"b@outlook.com" }},
                new Person { Name = "Person3", Emails = new string[]{ "c@mail.com" ,"c@outlook.com" } },
                new Person { Name = "Person4",  Emails = new string[]{ "d@mail.com" ,"d@outlook.com" } },
            };
            var emailArrayList = data.Select(p => p.Emails).ToList();
            var emails = data.SelectMany(p => p.Emails).ToList();
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
            foreach (var email in emailArrayList)
            {
                Console.WriteLine(string.Join(",", email));
            }
        }
    }
}
