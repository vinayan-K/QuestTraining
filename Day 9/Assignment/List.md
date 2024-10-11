### List
**1. Add()** 
 Adds an object to the end of the list.
 Example:

 

       List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);
        Console.WriteLine(string.Join(", ", numbers)); // Output: 10, 20

 **2. **Insert****

Inserts an item at a specified index.
Example:
`List<int> numbers = new List<int> { 1, 2, 3 };
numbers.Insert(1, 10); // Insert 10 at index 1
Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 10, 2, 3` 

 **3. **Remove****

Removes the first occurrence of a specific object from the list.
Example:
`List<int> numbers = new List<int> { 1, 2, 3, 2 };
numbers.Remove(2); // Removes the first occurrence of 2
Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 3, 2` 

 **4. **RemoveAt****

Removes the element at the specified index.
Example:
`List<int> numbers = new List<int> { 1, 2, 3, 4 };
numbers.RemoveAt(1); // Removes the element at index 1
Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 3, 4` 

 **5. **Clear****

Removes all elements from the list.
Example:
`List<int> numbers = new List<int> { 1, 2, 3 };
numbers.Clear();
Console.WriteLine(numbers.Count); // Output: 0` 

 **6. **Count****

Gets the number of elements in the list.
Example:
`List<int> numbers = new List<int> { 1, 2, 3 };
Console.WriteLine("Count: " + numbers.Count); // Output: Count: 3` 

**7. **Contains****

Determines whether the list contains a specific value.
Example:
`List<int> numbers = new List<int> { 1, 2, 3 };
bool hasTwo = numbers.Contains(2);
Console.WriteLine("Contains 2: " + hasTwo); // Output: Contains 2: True` 

 **8. **IndexOf****

Returns the zero-based index of the first occurrence of a value in the list.
Example:
`List<int> numbers = new List<int> { 1, 2, 3 };
int index = numbers.IndexOf(2);
Console.WriteLine("Index of 2: " + index); // Output: Index of 2: 1` 

**9. **Sort****

Sorts the elements in the list.
Example:
`List<int> numbers = new List<int> { 3, 1, 2 };
numbers.Sort();
Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 2, 3` 

 **10. **ForEach****

Performs the specified action on each element of the list.
Example:
`List<int> numbers = new List<int> { 1, 2, 3 };
numbers.ForEach(n => Console.WriteLine(n * 2)); // Output: 2, 4, 6` 

 **11. **ToArray****

Copies the elements of the list to a new array.
Example:
`List<int> numbers = new List<int> { 1, 2, 3 };
int[] array = numbers.ToArray();
Console.WriteLine(string.Join(", ", array)); // Output: 1, 2, 3`

**12.AddRange**

The `AddRange` method is used with `List<T>` in C# to add multiple elements to the end of the list at once.
Example:

        // Create a List
        List<int> numbers = new List<int> { 1, 2, 3 };

        // Create another collection to add
        List<int> moreNumbers = new List<int> { 4, 5, 6 };

        // Use AddRange to add multiple elements
        numbers.AddRange(moreNumbers);

        // Display the updated list
        Console.WriteLine("Numbers in the list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
 

