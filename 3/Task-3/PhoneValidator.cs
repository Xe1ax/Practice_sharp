using System.Text.RegularExpressions;

namespace Task_3
{
    internal class PhoneValidator
    {
       
        private static string phonePattern = @"[+][1-9]{3}[(][1-9]{2}[)][0-9]{3}[-]*[0-9]{2}[-]*[0-9]{2}";
        internal static bool Validate(string? input)
        {
            var regex = new Regex(phonePattern);
            return regex.IsMatch(input);    
        }
    }
}