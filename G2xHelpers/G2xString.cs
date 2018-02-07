using System.Text.RegularExpressions;

namespace G2xHelpers
{
    public static class G2xString
    {
        public static bool IsEmail(this string email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            return Regex.IsMatch(email, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
        }
        public static bool IsNumber(this string number)
        {
            if (string.IsNullOrEmpty(number)) return false;
            var rgx = new Regex(@"^-?((\d+)|(\d+[\.|\,]?\d+)|(\d{1,3}\.\d{3}\,\d+))$");
            return rgx.Match(number).Success;
        }
        public static string LimitChar(this string value, int maxChar, string finalChar)
        {
            if (string.IsNullOrEmpty(value)) return null;
            return $"{value.Substring(0, (value.Length > maxChar ? maxChar : value.Length))}{finalChar}";
        }
    }
}