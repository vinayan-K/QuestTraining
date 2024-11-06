using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        public static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            char[] chars = str1.ToCharArray();
            char[] chars2 = str2.ToCharArray();
            Array.Sort(chars);
            Array.Sort(chars2);
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != chars2[i])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string : ");
            var str1 = Console.ReadLine();
            Console.WriteLine("Enter the first string : ");
            var str2 = Console.ReadLine();
            bool isAnagram = IsAnagram(str1, str2);
              
            if (isAnagram)
            {
                Console.WriteLine("it is a anagram ");
            }
            else
            {
                Console.WriteLine("it is not a anagram");
            }
        }
    }
}
