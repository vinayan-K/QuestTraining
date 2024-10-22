using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    class SortedList<T>
    {
        private List<T> _data = new List<T>();
        public int Count => _data.Count;
        public void Add(T data)
        {
            _data.Add(data);
            _data.Sort();
        }
    }
    class MyDictionary<TKey,TValue>
    {
        private Dictionary<TKey, TValue> _data = new Dictionary<TKey, TValue>();
        public int Count => _data.Count;
        public void Add(TKey Key, TValue Value)
        {
            _data.Add(Key, Value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new MyDictionary<string, string>();
            data.Add("a", "b");

            var numberList = new SortedList<int>();
            numberList.Add(10);
            numberList.Add(20);

            var lst = new SortedList<string>();
            lst.Add("a");
        }
    }
}
