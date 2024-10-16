using System.Collections.Generic;

namespace Question1
{
    class Student
    {
        public string id;
        public string Name;
        public int Grade;

        public List<Mark> TotalMarks  = new List<Mark>();
       
        public override string ToString()
        {
            return $" Id: {id},Student Name: {Name} , Class: {Grade},";
        }
    }
    
}
