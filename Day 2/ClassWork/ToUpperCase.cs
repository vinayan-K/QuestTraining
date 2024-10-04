  // Converting name into uppercase //

  Console.Write("Enter the name : ");
  string name = Console.ReadLine();

  for (int i = 0; i < name.Length; i++)
  {
      char c = name[i];
      if (c >= 'a' && c <= 'z')
      {
          Console.Write((char)(c - 32));
      }
      else if (c == ' ')
      {
          Console.Write("_");
      }
      else
      {
          Console.Write(c);
      }

  }