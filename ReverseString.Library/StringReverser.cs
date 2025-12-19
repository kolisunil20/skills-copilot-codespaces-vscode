namespace ReverseString.Library;

/// <summary>
/// Provides methods for reversing strings.
/// </summary>
public class StringReverser
{
    /// <summary>
    /// Reverses the given input string.
    /// </summary>
    /// <param name="input">The string to reverse.</param>
    /// <returns>The reversed string.</returns>
    public string? Reverse(string? input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
