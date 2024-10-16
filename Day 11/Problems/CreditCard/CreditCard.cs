using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class CreditCard
    {
        
        public int CardNumber;
        public string Expiry;
        public int CVC;

        public override string ToString()
        {
            return $"Number : {CardNumber} , Expiry: {Expiry} , CVC : {CVC}";
        }
    }
}
