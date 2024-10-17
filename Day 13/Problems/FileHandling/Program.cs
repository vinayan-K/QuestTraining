using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\acer\Desktop\New folder";
            var fileName = "data.txt";
            var filePath = Path.Combine(path, fileName);
            //Directory.CreateDirectory(filePath);
            //Directory.Delete(path);
            //Directory.Delete(path,true);

            //File.Create(filePath);
            //File.WriteAllText(filePath, "Old Text From Code");
            File.AppendAllText(filePath, "Old Text From Code");
            File.AppendAllText(filePath, "Old Text From Code");

            //var content = File.ReadAllText(filePath);
            //string[] contentLines = File.ReadAllLines(filePath);
            //Console.WriteLine(content);

        }
    }
}
