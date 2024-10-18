using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee(10_000);
            employee.CalculateBonus();

            var manager = new Manager(20_000);
            manager.CalculateBonus();
        }
    }
}
