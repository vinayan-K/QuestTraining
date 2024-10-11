### Dictionary

 **1. Add**

Adds an element with the specified key and value to the dictionary.
Example:
`var dictionary = new Dictionary<string, int>();
dictionary.Add("apple", 1);
dictionary.Add("banana", 2);
Console.WriteLine(dictionary.Count); // Output: 2` 

 **2. Remove**

Removes the element with the specified key from the dictionary.
Example:
`dictionary.Remove("apple");
Console.WriteLine(dictionary.Count); // Output: 1` 

 **3. Clear**

Removes all elements from the dictionary.
Example:
`dictionary.Clear();
Console.WriteLine(dictionary.Count); // Output: 0` 

 **4. ContainsKey**

Determines whether the dictionary contains a specific key.
Example:
`bool hasBanana = dictionary.ContainsKey("banana");
Console.WriteLine("Contains 'banana': " + hasBanana); // Output: True` 

 **5. ContainsValue**

Determines whether the dictionary contains a specific value.
Example:
`bool hasValue1 = dictionary.ContainsValue(1);
Console.WriteLine("Contains value 1: " + hasValue1); // Output: False (after removing "apple")` 

 **6. TryGetValue**

Gets the value associated with the specified key. Returns `false` if the key does not exist.
Example:
`if (dictionary.TryGetValue("banana", out int value))
{
    Console.WriteLine("Value for 'banana': " + value); // Output: Value for 'banana': 2
}
else
{
    Console.WriteLine("'banana' not found.");
}` 

 **7. Indexers**

Allows access to values by key.
Example:
`dictionary["banana"] = 3; // Update value
Console.WriteLine("Updated value for 'banana': " + dictionary["banana"]); // Output: 3` 

 **8. Keys**

Gets a collection containing the keys in the dictionary.
Example:
`var keys = dictionary.Keys;
Console.WriteLine("Keys: " + string.Join(", ", keys)); // Output: banana` 

**9. Values**

Gets a collection containing the values in the dictionary.
Example:
`var values = dictionary.Values;
Console.WriteLine("Values: " + string.Join(", ", values)); // Output: 3` 

 **10. Count**

Gets the number of key-value pairs in the dictionary.
Example:
`Console.WriteLine("Count: " + dictionary.Count); // Output: 1` 

 **11. ToDictionary Method**
Converts the dictionary to a new dictionary of a different type.
Example:

    Dictionary<string, int> numbers = new Dictionary<string, int();
    numbers.Add("one", 1);
    numbers.Add("two", 2);
    Dictionary<int, string> reversed = numbers.ToDictionary(kvp =>kvp.Value, kvp => kvp.Key);
**12.TryAdd Method**
: Attempts to add a new key-value pair to the dictionary.
Example:

        // Try to add a key-value pair
        bool added = dict.TryAdd("apple", 1);
        Console.WriteLine($"Added 'apple': {added}"); // Output: True

        // Try to add the same key again
        added = dict.TryAdd("apple", 2);
        Console.WriteLine($"Added 'apple': {added}"); // Output: False




**13.GetOrAdd Method**
: Attempts to retrieve the value associated with a specified key. If the key doesn't exist, it adds a new key-value pair using a specified function.
Example:

   



        // Get or add a key-value pair
        int value = dict.GetOrAdd("banana", 2);
        Console.WriteLine($"Value for 'banana': {value}"); // Output: 2

        // Get the existing value
        value = dict.GetOrAdd("banana", 3);
        Console.WriteLine($"Value for 'banana': {value}"); // Output: 2 (not 3, since it already exists)




**14.RemoveAll Method**
: Removes all key-value pairs from the dictionary that satisfy a specified condition.
Example:

 

       ConcurrentDictionary<string, int> dict = new ConcurrentDictionary<string, int>(); dict.TryAdd("apple", 1); 
        dict.TryAdd("banana", 2); 
        dict.TryAdd("cherry", 3); 
        var keysToRemove = dict.Where(kvp => kvp.Value < 3).Select(kvp => kvp.Key).ToList();
         foreach (var key in keysToRemove)
          { dict.TryRemove(key, out _); }

