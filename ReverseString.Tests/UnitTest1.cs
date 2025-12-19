namespace ReverseString.Tests;

using ReverseString.Library;

public class StringReverserTests
{
    private readonly StringReverser _reverser;

    public StringReverserTests()
    {
        _reverser = new StringReverser();
    }

    [Fact]
    public void Reverse_SimpleString_ReturnsReversedString()
    {
        // Arrange
        string input = "hello";
        string? expected = "olleh";

        // Act
        string? result = _reverser.Reverse(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Reverse_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string? expected = "";

        // Act
        string? result = _reverser.Reverse(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Reverse_NullString_ReturnsNull()
    {
        // Arrange
        string? input = null;

        // Act
        string? result = _reverser.Reverse(input);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void Reverse_SingleCharacter_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";
        string? expected = "a";

        // Act
        string? result = _reverser.Reverse(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Reverse_StringWithSpaces_ReturnsReversedString()
    {
        // Arrange
        string input = "hello world";
        string? expected = "dlrow olleh";

        // Act
        string? result = _reverser.Reverse(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Reverse_StringWithNumbers_ReturnsReversedString()
    {
        // Arrange
        string input = "abc123";
        string? expected = "321cba";

        // Act
        string? result = _reverser.Reverse(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Reverse_Palindrome_ReturnsSameString()
    {
        // Arrange
        string input = "racecar";
        string? expected = "racecar";

        // Act
        string? result = _reverser.Reverse(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
