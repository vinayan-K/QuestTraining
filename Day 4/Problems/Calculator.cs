 static int add(int num1,int num2)
 {
    return num1+ num2;            
 }
 static int subtract(int num1, int num2)
 {
      return num1 - num2;            
 }
 static int multiply(int num1, int num2)
 {
     return num1 * num2;            
 }
 static int division(int num1, int num2)
 {
     return num1 / num2;           
 }
 static void Main(string[] args)
 {
     Console.WriteLine("Enter two numbers : ");
     int num1 = int.Parse(Console.ReadLine()) ;
     int num2 = int.Parse(Console.ReadLine());
     Console.WriteLine("Enter the operator : ");
     string op = Console.ReadLine();
     int result = 0 ;

     if (op == "+")
     {
         result = add(num1, num2);
     }
     else if (op == "-")
     {
         result = subtract(num1, num2);
     }
     else if (op == "*")
     {
         result = multiply(num1, num2);
     }
     else if(op == "/")
     {
         result = division(num1, num2);
     }

     Console.WriteLine( result);


     // Using singleline functions //

Console.WriteLine("Enter two numbers : ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
string op = Console.ReadLine();
int result = 0 ;

if (op == "+")
{
    result = add(num1, num2);
}
else if (op == "-")
{
    result = subtract(num1, num2);
}
else if (op == "*")
{
    result = multiply(num1, num2);
}
else if (op == "/")
{
    result = division(num1, num2);
}

Console.WriteLine("Result = " + result);