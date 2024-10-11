﻿### String

**1. `Length`**
Returns the number of characters in the string.
Example:

    string str = "Hello";
    Console.WriteLine(str.Length); // Output: 5


**2. `ToUpper()`**
Converts the string to uppercase.
Example:

    string str = "hello";
    Console.WriteLine(str.ToUpper()); // Output: HELLO


**3. `ToLower()`**
Converts the string to lowercase.
Example:

    string str = "HELLO";
    Console.WriteLine(str.ToLower()); // Output: hello

**4. `Trim()`**
Removes all leading and trailing whitespace characters.
Example:

    string str = "  Hello World  ";
    Console.WriteLine(str.Trim()); // Output: "Hello World"

**5. `Substring()`**
Extracts a substring from the string.
Example:

    string str = "Hello World";
    Console.WriteLine(str.Substring(6, 5)); // Output: World

 

**6. `IndexOf()`**
Returns the zero-based index of the first occurrence of a specified string.
Example:

    string str = "Hello World";
    Console.WriteLine(str.IndexOf("World")); // Output: 6

**7. `LastIndexOf()`**
Returns the zero-based index of the last occurrence of a specified string.
Example:

    string str = "Hello World, Welcome to the World";
    Console.WriteLine(str.LastIndexOf("World")); // Output: 26

**8. `Replace()`**
Replaces all occurrences of a specified substring with another substring.
Example:

    string str = "Hello World";
    Console.WriteLine(str.Replace("World", "C#")); // Output: Hello C#

**9. `Split()`**
Splits a string into an array of substrings based on a specified delimiter.
Example:

    string str = "apple,banana,orange";
    string[] fruits = str.Split(',');
    foreach (var fruit in fruits)
    {
        Console.WriteLine(fruit); // Output: apple banana orange
    }

**10. `Join()`**
Concatenates the elements of a string array, using a specified separator between each element.
Example:

    string[] fruits = { "apple", "banana", "orange" };
    Console.WriteLine(string.Join(", ", fruits)); // Output: apple, banana, orange

**11. `StartsWith()`**
Determines whether the string starts with a specified substring.
Example:

    string str = "Hello World";
    Console.WriteLine(str.StartsWith("Hello")); // Output: True

**12. `EndsWith()`**
Determines whether the string ends with a specified substring.
Example:

    string str = "Hello World";
    Console.WriteLine(str.EndsWith("World")); // Output: True

**13. `Contains()`**
Determines whether the string contains a specified substring.
Example:

    string str = "Hello World";
    Console.WriteLine(str.Contains("World")); // Output: True

**14. `PadLeft()`**
Pads the string on the left with spaces (or a specified character) to reach a specified length.
Example:

    string str = "5";
    Console.WriteLine(str.PadLeft(2, '0')); // Output: 05

**15. `PadRight()`**
Pads the string on the right with spaces (or a specified character) to reach a specified length.
Example:

    string str = "5";
    Console.WriteLine(str.PadRight(2, '0')); // Output: 50

**16. `TrimStart()`**
Removes all leading whitespace characters from the string.
Example:

    string str = "  Hello World  ";
    Console.WriteLine(str.TrimStart()); // Output: "Hello World  "

**17. `TrimEnd()`**
Removes all trailing whitespace characters from the string.
Example:

    string str = "  Hello World  ";
    Console.WriteLine(str.TrimEnd()); // Output: "  Hello World"

**18. `ToCharArray()`**
Converts the string to a character array.
Example:

    string str = "Hello";
    char[] charArray = str.ToCharArray();
    Console.WriteLine(charArray[0]); // Output: H


**19. `Insert()`**
Inserts a specified string at a specified index position.
Example:

    string str = "Hello World";
    Console.WriteLine(str.Insert(5, ", C#")); // Output: Hello, C# World


**20. `Remove()`**
Deletes a specified number of characters from the string, starting at a specified index.
Example:

    string str = "Hello World";
    Console.WriteLine(str.Remove(5, 6)); // Output: Hello


**21. `Equals()`**
Determines whether two specified string instances are equal.
Example:

    string str1 = "Hello";
    string str2 = "Hello";
    Console.WriteLine(str1.Equals(str2)); // Output: True


**22. `Format()`**
Formats a string using placeholders.
Example:

    string name = "John";
    int age = 30;
    Console.WriteLine(string.Format("My name is {0} and I am {1} years old.", name, age)); // Output: My name is John and I am 30 years old.

**23. `String Interpolation`**
A modern way to format strings in C#.
Example:

    string name = "John";
    int age = 30;
    Console.WriteLine($"My name is {name} and I am {age} years old."); // Output: My name is John and I am 30 years old.

**24. `EqualsIgnoreCase()`**
Compares two strings and ignores case.
Example:

    string str1 = "hello";
    string str2 = "HELLO";
    Console.WriteLine(string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase)); // Output: True


**25. `Compare()`**
Compares two strings and returns an integer that indicates their relative position in the sort order.
Example:

    string str1 = "abc";
    string str2 = "def";
    Console.WriteLine(string.Compare(str1, str2)); // Output: Negative number (str1 is less than str2)


**26. `CompareTo()`**
Compares this instance to a specified object and returns an integer that indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified object.
Example:

    string str1 = "abc";
    Console.WriteLine(str1.CompareTo("def")); // Output: Negative number

**27. `GetHashCode()`**
Returns a hash code for the string.
Example:
 
    string str = "Hello";
    Console.WriteLine(str.GetHashCode());

**28. `ToString()`**
Returns the string representation of the current instance.
Example:

    object obj = "Hello World";
    string str = obj.ToString(); // Output: Hello World


**29. `Copy()`**
Creates a new instance of String with the same value as a specified String.
Example:

    string str = "Hello";
    string copy = string.Copy(str);
    Console.WriteLine(copy); // Output: Hello

**30. `Contains()`**
Checks if a string contains a specific substring.
Example:

    string str = "Hello World";
    Console.WriteLine(str.Contains("World")); // Output: True









