using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ExamITP
{
    class ValidateExam
    {
        static Regex ValidEmailRegex = CreateValidEmailRegex();
        public static bool isLetter(String text)
        {
            bool hasLetter = false;
            foreach (char letter in text)
            {
                if (!char.IsLetter(letter))
                {
                    hasLetter = true;
                    return hasLetter;
                }

            }

            return hasLetter;
        }

        public static bool isNumber(String text)
        {
            bool hasNumber = false;
            foreach (char number in text)
            {
                if (!char.IsDigit(number))
                {
                    hasNumber = true;
                    return hasNumber;
                }

            }

            return hasNumber;
        }

        public static bool isMaxLength(int text)
        {
            bool hasMax = false;

            if (text > 10)
            {
                hasMax = true;
                return hasMax;
            }



            return hasMax;
        }

        public static bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }
    }
}
