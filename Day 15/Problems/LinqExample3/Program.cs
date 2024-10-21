using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample3
{
    class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public override string ToString() => $"{Name}  -  {Country}";
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Person>()
            {
                new Person {Name = "Person1", Country = "US" },
                new Person { Name = "Person2", Country = "IN" },
                new Person { Name = "Person3", Country = "CA" },
                new Person { Name = "Person4", Country = "IN" },
            };
            var groups = data.GroupBy(x => x.Country);
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key}  -  {group.Count()}");
                foreach (var Person in group)
                {
                    Console.WriteLine(Person);
                }
            }
        }
    }
}
