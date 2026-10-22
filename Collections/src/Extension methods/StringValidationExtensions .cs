using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Extension_methods
{
    public static class StringValidationExtensions
    {

        private static readonly Regex EgyptianPhoneRegex =
        new Regex(@"^(?:\+20|0)(10|11|12|15)\d{8}$", RegexOptions.Compiled);

        
        private static readonly Regex EgyptianNationalIdRegex =
            new Regex(@"^[23]\d{13}$", RegexOptions.Compiled);

        public static bool IsValidEgyptianPhone(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            return EgyptianPhoneRegex.IsMatch(input);
        }
        public static bool IsValidEgyptianNationalId(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            return EgyptianNationalIdRegex.IsMatch(input);
        }
    }
}
