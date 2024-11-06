using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousConsoleApp
{
    internal class Program
    {
        static async Task<string> ReadFileAsync(string filePath)
        {
            await Task.Delay(1000);
            return File.ReadAllText(filePath);
        }
        static async Task Main()
        {
            string filePath = @"C:\Users\acer\Desktop\New folder\TextFile.txt";
            try
            {
                var fileContent = await ReadFileAsync(filePath);
                Console.WriteLine(fileContent);

            }
            catch (FileNotFoundException) 
            {
                Console.WriteLine($"Error : {filePath} not found");
            }
        }
    }
}
