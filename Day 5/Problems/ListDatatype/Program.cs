using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> lst = new List<int>();
            //// var lst = new List<int>();
            //lst.Add(10);
            //lst.Add(20);
            //lst.Add(30);
            //var values = new int[] { 10, 200, 300 };
            //lst.AddRange(values);
            //lst[0] = 1;
            //lst.Remove(10);
            //lst.RemoveAt(3);

            //for (int i = 0; i < lst.Count; i++)
            //{
            //    Console.Write(lst[i]+ " ");
            //}

            
            List<int> lst = new List<int>(5);
            for (int i = 0; i < 5 ; i++)
            {
                Console.WriteLine($"Enter the numbers {i+1}: ");
                lst.Add( int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] % 2 == 0)
                { 
                    lst.RemoveAt(i);
                }               
            }
            Console.WriteLine(string.Join(",",lst));
            
        }
    }
}
