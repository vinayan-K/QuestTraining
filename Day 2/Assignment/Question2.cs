//Code for printing rectangles using "*" //
 Console.WriteLine("Enter the width : ");
 int width = int.Parse(Console.ReadLine());
 Console.WriteLine("Enter the length : ");
 int length = int.Parse(Console.ReadLine());
 string space = new string(' ', length - 2);

 for (int i = 0; i < length; i++)
 {
    Console.Write("*");
 }
 Console.WriteLine();
 for (int j = 0; j < width - 1; j++)
 {
    Console.WriteLine("*" + space + "*");

    if (j == width - 2)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write("*");

        }
    }
 }
 Console.WriteLine();