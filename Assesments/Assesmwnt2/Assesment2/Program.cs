using Assesment2.Models;
using Assesment2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            var manger = new Manager();
            manger.Run();

        }
    }
}
