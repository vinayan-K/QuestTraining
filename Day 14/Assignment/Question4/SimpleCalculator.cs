namespace Question4
{
    class SimpleCalculator : ICalculator
    {
        public int a { get; set; }
        public int b { get; set; }
        public  int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a- b;  
        
    }
}
