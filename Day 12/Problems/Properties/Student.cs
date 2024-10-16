namespace Poroperties
{
    class Student
    {
        public string Name;
        private int age;
        public int Age
        { get => age ;
            set
            {
                if (value > 0 && value < 50)
                {
                    age = value;
                }
            }
        }
    }
}
