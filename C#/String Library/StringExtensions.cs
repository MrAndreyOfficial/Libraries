using System.Text;

namespace String_Library;

public static class StringExtensions
{
    public static string Append(this string str, string value)
    {
        var stringBuilder = new StringBuilder(str);

        stringBuilder.Append(value);

        return stringBuilder.ToString();
    }

    public static string Remove(this string str, int startIndex, int endIndex)
    {
        var stringBuilder = new StringBuilder(str);

        stringBuilder.Remove(startIndex, endIndex);

        return stringBuilder.ToString();
    }

    public static char GetFirstChar(this string str) => str[0];
    public static char GetLastChar(this string str) => str[^1];
}
