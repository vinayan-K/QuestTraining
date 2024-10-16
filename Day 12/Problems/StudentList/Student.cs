using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class Student
    {
        public string id;
        public string Name;
        public int Grade;
        public override string ToString()
        {
            return $" Id: {id},Student Name: {Name} , Class: {Grade}";
        }
    }
}
