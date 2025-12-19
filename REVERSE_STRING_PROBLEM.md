# Reverse String Problem in C#

## Overview

This repository now includes a complete C# implementation of a reverse string problem. The implementation demonstrates:
- Clean architecture with separation of concerns
- Comprehensive unit testing using xUnit
- Interactive console application for demonstration
- Proper null safety with nullable reference types
- Full XML documentation

## Quick Start

### Build the Project
```bash
dotnet build ReverseString.sln
```

### Run Tests
```bash
dotnet test ReverseString.sln
```

### Try the Demo
```bash
dotnet run --project ReverseString.Demo/ReverseString.Demo.csproj
```

## What's Included

### 1. **ReverseString.Library** - Core Implementation
A class library containing the `StringReverser` class with a `Reverse` method that:
- Accepts a string input
- Returns the reversed string
- Handles null and empty strings gracefully
- Uses `Array.Reverse()` for efficient reversal

**Location:** `ReverseString.Library/StringReverser.cs`

### 2. **ReverseString.Tests** - Unit Tests
Comprehensive test suite with 7 test cases covering:
- ✅ Simple string reversal
- ✅ Empty string handling
- ✅ Null string handling
- ✅ Single character strings
- ✅ Strings with spaces
- ✅ Strings with numbers
- ✅ Palindrome strings

**Location:** `ReverseString.Tests/UnitTest1.cs`

All tests pass successfully.

### 3. **ReverseString.Demo** - Interactive Console Application
A demonstration program that:
- Shows several pre-defined examples
- Allows interactive user input
- Demonstrates the functionality in real-time

**Location:** `ReverseString.Demo/Program.cs`

## Examples

```csharp
using ReverseString.Library;

var reverser = new StringReverser();

// Simple reversal
string result = reverser.Reverse("hello");
// Output: "olleh"

// With spaces
result = reverser.Reverse("hello world");
// Output: "dlrow olleh"

// With numbers
result = reverser.Reverse("abc123");
// Output: "321cba"

// Palindrome
result = reverser.Reverse("racecar");
// Output: "racecar"
```

## Project Structure

```
skills-copilot-codespaces-vscode/
├── ReverseString.sln                      # Solution file
├── ReverseString.Library/                 # Core library
│   ├── StringReverser.cs                  # Main implementation
│   ├── README.md                          # Detailed documentation
│   └── ReverseString.Library.csproj
├── ReverseString.Tests/                   # Unit tests
│   ├── UnitTest1.cs                       # Test cases
│   └── ReverseString.Tests.csproj
├── ReverseString.Demo/                    # Demo application
│   ├── Program.cs                         # Interactive demo
│   └── ReverseString.Demo.csproj
└── REVERSE_STRING_PROBLEM.md             # This file
```

## Technical Details

- **Framework:** .NET 10.0
- **Testing Framework:** xUnit
- **Language:** C# with nullable reference types enabled
- **Build System:** .NET SDK

## Usage in Your Own Code

To use the reverse string functionality in your own project:

1. Reference the `ReverseString.Library` project
2. Create an instance of `StringReverser`
3. Call the `Reverse` method with your string

```csharp
var reverser = new StringReverser();
string reversed = reverser.Reverse("your string here");
```

## Documentation

For more detailed information about the implementation, see:
- [ReverseString.Library/README.md](ReverseString.Library/README.md) - Detailed library documentation

## Testing

The project includes comprehensive unit tests. To run them:

```bash
# Run all tests
dotnet test ReverseString.sln

# Run with detailed output
dotnet test ReverseString.sln --logger "console;verbosity=detailed"

# Run specific test project
dotnet test ReverseString.Tests/ReverseString.Tests.csproj
```

## Security

This implementation has been scanned with CodeQL and contains no security vulnerabilities.

## License

This implementation is part of the GitHub Skills - Copilot Codespaces VSCode repository.
