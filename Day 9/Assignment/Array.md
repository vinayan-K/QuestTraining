### Array
 **1. `Length`**

Returns the number of elements in the array.
Example:
`int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine("Length of array: " + numbers.Length);` 

 **2. `GetValue`**

Retrieves the value at a specified index.
Example:
`int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine("Value at index 2: " + numbers.GetValue(2));` 

 **3. `SetValue`**

Sets the value at a specified index.
Example:
`int[] numbers = new int[5];
numbers.SetValue(10, 0); // Set first element to 10
Console.WriteLine("First element: " + numbers[0]);` 

 **4. `Copy`**

Copies elements from one array to another.
Example:
`int[] source = { 1, 2, 3 };
int[] destination = new int[3];
Array.Copy(source, destination, source.Length);
Console.WriteLine("Destination array: " + string.Join(", ", destination));` 

 **5. `Clone`**

Creates a shallow copy of the array.
Example:
`int[] original = { 1, 2, 3 };
int[] cloned = (int[])original.Clone();
Console.WriteLine("Cloned array: " + string.Join(", ", cloned));` 

**6. `Sort`**

Sorts the elements of the array.
Example:
`int[] numbers = { 5, 3, 2, 4, 1 };
Array.Sort(numbers);
Console.WriteLine("Sorted array: " + string.Join(", ", numbers));` 

**7. `Reverse`**

Reverses the order of the elements in the array.
Example:
`int[] numbers = { 1, 2, 3, 4, 5 };
Array.Reverse(numbers);
Console.WriteLine("Reversed array: " + string.Join(", ", numbers));` 

 **8. `IndexOf` (from `Array`)**

Finds the index of a specified element.
Example:
`int[] numbers = { 1, 2, 3, 4, 5 };
int index = Array.IndexOf(numbers, 3);
Console.WriteLine("Index of 3: " + index);` 

**9. `Find` (from `Array`)**

Finds the first element that matches the conditions defined by the specified predicate.
Example:
`int[] numbers = { 1, 2, 3, 4, 5 };
int found = Array.Find(numbers, n => n > 3);
Console.WriteLine("First number greater than 3: " + found);` 

**10. `ForEach` (from `Array`)**

Executes a specified action on each element of the array.
Example:
`int[] numbers = { 1, 2, 3, 4, 5 };
Array.ForEach(numbers, n => Console.WriteLine(n * 2)); // Prints each element multiplied by 2` 

**11. `Rank`**
Gets the number of dimensions in the array.
Example: 
  

       int[,] numbers = { { 1, 2 }, { 3, 4 } };
            int rank = numbers.Rank;
            Console.WriteLine(rank);// Output: 2
 **12. `BinarySearch(Array array, object value)`**
Searches for the specified object and returns the zero-based index of the first occurrence within the entire array.
Example:

    int[] numbers = { 1, 2, 3, 4, 5 };
    int index = Array.BinarySearch(numbers, 3);
    Console.WriteLine(index); // Output: 2           

**13. `GetLength(int dimension)`**
Gets the number of elements in the specified dimension.
Example:

    int[,] numbers = { { 1, 2 }, { 3, 4 } };
    int length = numbers.GetLength(0);
    Console.WriteLine(length); // Output: 2
  
**14. `GetLowerBound(int dimension)`**
Gets the lower bound of the specified dimension.
Example:

    int[,] numbers = { { 1, 2 }, { 3, 4 } };
    int lowerBound = numbers.GetLowerBound(0);
    Console.WriteLine(lowerBound); // Output: 0
    
**15. `GetUpperBound(int dimension)`**
Gets the upper bound of the specified dimension.
Example:

    int[,] numbers = { { 1, 2 }, { 3, 4 } };
    int upperBound = numbers.GetUpperBound(0);
    Console.WriteLine(upperBound); // Output: 1

**16. `Clear(Array array, int index, int length)`**
Sets a range of elements in the array to zero, to null, or to a default value.
Example:

    int[] numbers = { 1, 2, 3, 4, 5 };
    Array.Clear(numbers, 1, 2);
    Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 0, 0, 4, 5
**17. `CreateInstance(Type type, int length)`**
Creates a new array of the specified type and length.
Example:

    int[] numbers = (int[])Array.CreateInstance(typeof(int), 5);
    Console.WriteLine(numbers.Length); // Output: 5
**18. `LastIndexOf(Array array, object value)`**
Searches for the specified object and returns the zero-based index of the last occurrence within the entire array.
Example:

    int[] numbers = { 1, 2, 3, 4, 5, 3 };
    int index = Array.LastIndexOf(numbers, 3);
    Console.WriteLine(index); // Output: 5
**19. `Resize(ref Array array, int newSize)`**
Resizes an array to the specified size.
Example:

    int[] numbers = { 1, 2, 3, 4, 5 };
    Console.WriteLine("Original array: " + string.Join(", ", numbers));
    Array.Resize(ref numbers, 8);
    Console.WriteLine("Resized array: " + string.Join(", ", numbers));







