## Example

```
using Palindrome;

Console.WriteLine(PalindromeChecker.Check("Php")); // false
Console.WriteLine(PalindromeChecker.Check("Php", true)); // true
```

## Methods
```
PalindromeChecker.Check(string value, [bool upperCase]) // value for check
optional:
    uppercase: 
        true covert to uppercase.
        false don't convert to uppercase.
```
