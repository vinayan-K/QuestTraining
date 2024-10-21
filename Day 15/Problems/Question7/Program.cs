using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var names = new List<string> { "Alice", "Bob", "Charlie", "David" };
            var marks = new List<int> { 85, 75, 90, 60 };

            //var result = studentNames
            //    .Where((name, index) => studentGrades[index] > 80)
            //    .ToList();
            //Console.WriteLine("Students scoring above 80:");
            var res = names.Zip(marks, (studentNames, studentGrades) => { return new { studentNames, studentGrades }; })
                       .Where(S => S.studentGrades > 80)
                       .Select(S => S.studentNames);
            
            foreach (var student in res)
            {
                Console.WriteLine(student);
            }
        }
    }
}
