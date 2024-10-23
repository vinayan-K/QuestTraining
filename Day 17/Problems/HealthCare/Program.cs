using HealthCare.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var  data = new DataStore();
            var healthCareManager = new HealthCareManager(data);
            healthCareManager.ListUpcomingAppontmentsInNextSevenDays();

        }
    }
}
