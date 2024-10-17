using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    internal class Program
    {
        public enum ConverTo
        {
            UpperCase,
            LowerCase
            
        }
        public static void ConvertCasing(string input, ConverTo targetType)
        {
            switch (targetType)
            {
                case ConverTo.UpperCase:
                    Console.WriteLine(input.ToUpper());
                    break;
                case ConverTo.LowerCase:
                    Console.WriteLine(input.ToLower());
                    break;
            }
        }
        static void Main(string[] args)
        {
            ConvertCasing("Hello",ConverTo.LowerCase); 
        }
    }
}
