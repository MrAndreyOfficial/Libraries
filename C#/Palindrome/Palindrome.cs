namespace Palindrome;

public static class PalindromeChecker
{   
    /// <summary>
    /// <param name="upperCase">
    /// <para>Default: false</para>
    /// <para>true: Convert to uppercase</para>
    /// <para>false: Do not convert to uppercase</para>
    /// </param>
    /// </summary>
    public static bool Check(string value, bool upperCase = false)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentNullException(nameof(value), $"{value} is null or empty");

        return Is(upperCase ? value.ToUpper() : value);
    }

    private static bool Is(string value)
    {
                if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentNullException(nameof(value), $"{value} is null or empty");

        return value.SequenceEqual(value.Reverse());
    }
}
