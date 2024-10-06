// Finding sum of even numbers in an array //

            int[] array = new int[5];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write($"Enter the numbers {i} : ");
                array[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum = sum + array[i];
                  
                }
            }
            Console.WriteLine(sum);



 
 // Array resizing and finding sum //
 
 int[] array = new int[0]; 
 int sum = 0;
 int index = 0;
 while (true)
 {
     Console.Write("Enter a number or press 'q' to exit: ");
     string input = Console.ReadLine();

     if (input.ToLower() == "q")
     {
         break; 
     }
     int number = int.Parse(input); 
     Array.Resize(ref array, array.Length + 1);
     array[index] = number; 
     sum += number; 
     index++;
 }
          
 Console.WriteLine($"The sum of the entered numbers is: {sum}");