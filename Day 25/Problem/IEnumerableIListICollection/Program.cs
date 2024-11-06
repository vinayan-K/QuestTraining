using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableIListICollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("IEnumerable");
            IEnumerable<int> ints = list;
            foreach (int i in ints)
            {
                Console.Write(i + ",");
            }

            Console.WriteLine("ICollection");
            ICollection<int> collection = list;
            collection.Add(10);
            collection.Add(11);
            collection.Remove(11);
            Console.WriteLine($"contains 2 : " + collection.Contains(3));
            Console.WriteLine("Count : " + collection.Count);
            foreach (var item in collection)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("IList");
            IList<int> listNumbers = list;
            Console.WriteLine($"Element at index 4: {listNumbers[4]}");
            listNumbers[2] = 100; 
            listNumbers.Insert(2, 50);
            listNumbers.RemoveAt(4); 
            
            Console.WriteLine("Elements :");
            foreach (var num in listNumbers)
            {
                Console.Write(num + ","); 
            }
        }
    }
}
