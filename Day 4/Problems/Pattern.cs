// Question 1 //

            Console.WriteLine("Enter the number of rows :");
            int row = int.Parse(Console.ReadLine());
            for (int i = 0; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


 // Question 2 //    

 onsole.WriteLine("Enter the number of rows :");
            int row = int.Parse(Console.ReadLine());
            int index = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{index,3}");
                    index++;
                }
                Console.WriteLine();
            }

 // Question 3 //

 onsole.WriteLine("Enter the number of rows :");
            int row = int.Parse(Console.ReadLine());
            for (int i = 0; i < row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


// Question 4 //

  int[] array = { 1, 2, 3, 4 };

  if (array.Length % 2 != 0)
  {
      var firstHalf = array.Take(array.Length / 2).Reverse().ToArray();
      var secondHalf = array.Skip(array.Length / 2 + 1).Reverse().ToArray();
      firstHalf.CopyTo(array, 0);
      secondHalf.CopyTo(array, array.Length / 2 + 1);
      Console.WriteLine(string.Join(" ", array));
  }
  else
  {
      var firstHalf = array.Take(array.Length / 2).Reverse().ToArray();
      var secondHalf = array.Skip(array.Length / 2).Reverse().ToArray();
      firstHalf.CopyTo(array, 0);
      secondHalf.CopyTo(array, array.Length / 2 );
      Console.WriteLine(string.Join(" ", array));
  }