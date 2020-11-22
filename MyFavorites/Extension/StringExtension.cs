using System;
using System.Text.RegularExpressions;

namespace MyFavorites.Extension
{
    public static class StringExtension
    {
        public static string RemoveSpaces(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return text.Trim().Replace(" ", string.Empty);
        }

        public static string DecimalBraces(this string text)
        {
            return text.Trim().Replace(",", ".");
        }

        public static bool IsValidMailAddress(this string text)
            => Regex.IsMatch(text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        
        public static bool IsValidUsername(this string text)
            => Regex.IsMatch(text, "^[a-zA-Z0-9]*$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

        public static string CustomFormat(this string text, params object[] args)
        {
            return string.Format(text, args);
        }
    }
}