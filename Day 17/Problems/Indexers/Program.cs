using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersExample
{
    class ShoppingList
    {
        //private string[] _items { get; set; } = new string[10];
        private List<string> _items = new List<string>();
        public string this[int index]
        {
            //get => _items[index];
            //set { _items[index] = value; }
            get
            {
                if (index >= _items.Count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return _items[index];
            }
            set
            {
                if (index >= _items.Count)
                {
                    _items.Add(value);
                }
                else
                {
                    _items[index] = value;
                }
            }
        }
        public int TotalItems => _items.Count(i => i != null);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ShoppingList();
            list[0] = "apple";
            list[1] = "banana";
            Console.WriteLine(list.TotalItems);
        }
    }
}
