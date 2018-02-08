using System.Text;
using System.Text.RegularExpressions;

namespace G2xHelpers
{
    public static class G2xString
    {
        public static bool IsEmail(this string value)
        {
            return !string.IsNullOrEmpty(value) && Regex.IsMatch(value, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
        }
        public static bool IsNumber(this string value)
        {
            return !string.IsNullOrEmpty(value) && new Regex(@"^-?((\d+)|(\d+[\.|\,]?\d+)|(\d{1,3}\.\d{3}\,\d+))$").Match(value).Success;
        }
        public static string LimitChar(this string value, int maxChar, string finalChar)
        {
            return string.IsNullOrEmpty(value) ? null : $"{value.Substring(0, (value.Length > maxChar ? maxChar : value.Length))}{finalChar}";
        }
        public static string ToCamelCase(this string value)
        {
            return string.IsNullOrEmpty(value) ? null : Regex.Replace(value, @"(_|-|\s)(\w)", m=> m.Groups[2].ToString().ToUpper());
        }
        public static string RemoveAccents(this string value)
        {
            return string.IsNullOrEmpty(value) ? null : Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(value));
        }
    }
}