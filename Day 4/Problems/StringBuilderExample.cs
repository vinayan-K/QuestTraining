// Question 1 //
var sb = new StringBuilder();
var res = " ";
var arr = new string[] { "name0", "name1", "name2", "name3", "name4" };
for (int i = 0; i < arr.Length; i++) 
{
    sb.AppendFormat("{0},{1}", arr[i],i);
}
res= sb.ToString();
Console.WriteLine(res);

// Question 2 //
Console.WriteLine("Enter a word");
string words = Console.ReadLine().Trim().ToLower();
var reverse = string.Concat(words.Reverse());
if (words == reverse)
{
    Console.WriteLine("It is a pallindrom");
}
else
{
    Console.WriteLine("It is not a pallindrom");
}


// Question 3 //
Console.WriteLine("Enter a word :");
var input = Console.ReadLine().ToLower().Split();
string vowels = "aeiou";
string s = " ";
foreach (var chr in input)
{               
    if (vowels.Contains(chr))
    {
        Console.WriteLine(chr + " ");
    }
    Console.WriteLine();
}