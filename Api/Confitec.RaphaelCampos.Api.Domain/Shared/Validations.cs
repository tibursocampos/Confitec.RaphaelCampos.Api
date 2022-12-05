using System;
using System.Text.RegularExpressions;

namespace Confitec.RaphaelCampos.Api.Domain.Utils
{
    public static class Validations
    {
        public const string EMAIL_FORMAT = @"\b[a-z0-9._-]+@[a-z0-9]+(\.[a-z0-9]+)+\b";
        public const string INVALID_EMAIL = "The email format entered is not valid.";
        public const string INVALID_DATE = "Invalid Date";
        public static bool IsValidEmailFormat(this string str)
        {
            return Regex.IsMatch(str, EMAIL_FORMAT);
        }

        public static string ValidateEmailFormat(this string email)
        {
            email = email.ToLower();
            var emailRegex = new Regex(EMAIL_FORMAT);
            var match = emailRegex.Match(email).Value;

            if (string.IsNullOrEmpty(match))
            {
                throw new FormatException($"{INVALID_EMAIL} | {email}");
            }

            return match;
        }

        public static DateTime IsValidBirthdayDate(DateTime birthdayDate)
        {
            var result = DateTime.Now.CompareTo(birthdayDate);
            var compare = result > (int)default;

            if(!compare)
            {
                throw new FormatException($"{INVALID_DATE} | {birthdayDate}");
            }

            return birthdayDate;
        }
    }
}
