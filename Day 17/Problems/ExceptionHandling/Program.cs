using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two numbers : ");
                int i = int.Parse(Console.ReadLine());
                int j = int.Parse(Console.ReadLine());
                Console.WriteLine(i/j);
            }
            catch (OverflowException )
            {
                Console.WriteLine("Number too large");
            }
            catch(DivideByZeroException )
            {
                Console.WriteLine("Can not divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
