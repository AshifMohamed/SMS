using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPLibrary
{
    class BookRegValidation
    {
        public static bool isLetter(String text)
        {
            bool hasLetter = false;
            foreach (char letter in text)
            {
                if (char.IsLetter(letter))
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
                if (char.IsDigit(number))
                {
                    hasNumber = true;
                    return hasNumber;
                }
            }
            return hasNumber;
        }

        public static bool IsAllLettersOrDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }

    }
}
