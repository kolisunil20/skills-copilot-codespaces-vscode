# Reverse String Problem in C#

This is a simple C# implementation of a reverse string problem, demonstrating how to reverse any given string.

## Problem Description

Given an input string, reverse the order of characters in the string.

### Examples:
- Input: `"hello"` → Output: `"olleh"`
- Input: `"world"` → Output: `"dlrow"`
- Input: `"abc123"` → Output: `"321cba"`
- Input: `"racecar"` → Output: `"racecar"` (palindrome)

## Implementation

The `StringReverser` class provides a `Reverse` method that:
1. Handles null and empty strings gracefully
2. Converts the string to a character array
3. Reverses the array using `Array.Reverse()`
4. Returns the reversed string

## Usage

```csharp
using ReverseString.Library;

var reverser = new StringReverser();
string result = reverser.Reverse("hello");
Console.WriteLine(result); // Output: "olleh"
```

## Building the Project

To build the project:
```bash
dotnet build ReverseString.sln
```

## Running Tests

To run the unit tests:
```bash
dotnet test ReverseString.sln
```

## Test Coverage

The test suite includes:
- ✅ Simple string reversal
- ✅ Empty string handling
- ✅ Null string handling
- ✅ Single character strings
- ✅ Strings with spaces
- ✅ Strings with numbers
- ✅ Palindrome strings

## Project Structure

```
├── ReverseString.sln              # Solution file
├── ReverseString.Library/         # Main library
│   ├── Class1.cs                  # StringReverser implementation
│   └── ReverseString.Library.csproj
└── ReverseString.Tests/           # Unit tests
    ├── UnitTest1.cs               # Test cases
    └── ReverseString.Tests.csproj
```
