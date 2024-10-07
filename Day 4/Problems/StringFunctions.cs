using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Converting input to upper case //
            Console.WriteLine(" Enter the names ");
            string[] names = new string[5];
            for (int i = 0; i < 5; i++)
            {
                names[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(names[i].ToUpper());
            }

            // Input : "HeLlO wOrLd" , output : "hElLo WoRlD" //
            string word = "HeLlO wOrLd";
            string s = " ";
            foreach (var chr in word)
            {
                char res = char.IsUpper(chr) ? char.ToLower(chr) : char.ToUpper(chr);
                s=s + res;
            }
            Console.WriteLine(s);



            // Searching elements in an array //
            string[] names = new string[] { "Alice", "Bob", "Charlie", "Diana", "Ethan" };
            Console.WriteLine("Enter the name for search : ");
            string tosearch = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i].ToLower();
                if (name == tosearch.ToLower())
                {
                    Console.WriteLine("Name Found ");
                    
                }
                else
                {
                    Console.WriteLine("Not found");
                    
                }
            
            }


            // Question 1 //
            string[] names = new string[] { "Alice", "Bob", "Charlie", "Diana", "Ethan" };
            Console.WriteLine("Enter the alphabet for search : ");
            string tosearch = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i].ToLower();
                if (name.Contains(tosearch.ToLower()))
                {
                    Console.WriteLine("Alphabet Found ");

                }
                else
                {
                    Console.WriteLine("Not found");

                }

            }


            // Question 2 //
            
                string word = "one, 2, Three, Four, 2" ;
                string[] words = new string[] { "one", "Two", "Three", "Four","Five" };
                var sb = new StringBuilder();
                var inputItems = word.Replace(" ", "").Split(',');
                
                foreach (var item in inputItems)
                {
                    if (item.Length <= 2)
                    {
                        int number = int.Parse(item);
                        string text = words[number-1];
                        sb.Append($"{text}, ");
                    }
                    else 
                    {
                        sb.Append($"{item}, ");
                    }
                    
                }
                Console.WriteLine(sb.ToString());

                // Question 3 //
            string text = "This is a long long day";
            string[] words = text.Split(' ');
            string[] wordsFound = new string[words.Length];
            int wordsCheckedCount = 0;  
            foreach (string word in words)
            {
                if(wordsFound.Contains(word))
                {
                    continue;
                }

                int count = 0;
                foreach (var item in words)
                {
                    if (word == item)
                    {
                        count++;                        
                    }
                }
                wordsFound[wordsCheckedCount] = word;
                wordsCheckedCount++;
                Console.WriteLine(word +" "+ count);
            }
        }
    }
}


