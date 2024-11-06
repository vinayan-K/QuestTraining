using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    class SimpleCollection
    {
        private int[] numbers;
        public SimpleCollection(int size)
        {
            numbers = new int[size];
        }
        public int this[int index]
        {
            get
            {
                if 
                    (index >= 0 && index < numbers.Length)
                    return numbers[index];  
                else
                    throw new IndexOutOfRangeException("Index out of range!");
            }
            set
            {
                if (index >= 0 && index < numbers.Length)
                    numbers[index] = value;  
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCollection collection = new SimpleCollection(3);
            collection[0] = 10;
            collection[1] = 20;
            collection[2] = 30;

            Console.WriteLine("Element at index 0: " + collection[0]);
            Console.WriteLine("Element at index 1: " + collection[1]);
            Console.WriteLine("Element at index 2: " + collection[2]);
        }
    }
}
