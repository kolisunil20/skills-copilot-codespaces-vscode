using ReverseString.Library;

Console.WriteLine("=== Reverse String Demo ===\n");

var reverser = new StringReverser();

// Example 1: Simple string
string input1 = "hello";
string? result1 = reverser.Reverse(input1);
Console.WriteLine($"Input:  '{input1}'");
Console.WriteLine($"Output: '{result1}'\n");

// Example 2: String with spaces
string input2 = "hello world";
string? result2 = reverser.Reverse(input2);
Console.WriteLine($"Input:  '{input2}'");
Console.WriteLine($"Output: '{result2}'\n");

// Example 3: String with numbers
string input3 = "abc123";
string? result3 = reverser.Reverse(input3);
Console.WriteLine($"Input:  '{input3}'");
Console.WriteLine($"Output: '{result3}'\n");

// Example 4: Palindrome
string input4 = "racecar";
string? result4 = reverser.Reverse(input4);
Console.WriteLine($"Input:  '{input4}'");
Console.WriteLine($"Output: '{result4}' (palindrome)\n");

// Example 5: Empty string
string input5 = "";
string? result5 = reverser.Reverse(input5);
Console.WriteLine($"Input:  '{input5}' (empty)");
Console.WriteLine($"Output: '{result5}' (empty)\n");

// Interactive mode
Console.WriteLine("Enter a string to reverse (or press Enter to exit):");
string? userInput = Console.ReadLine();

while (!string.IsNullOrEmpty(userInput))
{
    string? userResult = reverser.Reverse(userInput);
    Console.WriteLine($"Reversed: '{userResult}'\n");
    
    Console.WriteLine("Enter another string (or press Enter to exit):");
    userInput = Console.ReadLine();
}

Console.WriteLine("Thank you for using the Reverse String Demo!");
