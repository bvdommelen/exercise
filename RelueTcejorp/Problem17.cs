using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /*
     * If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
     * If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
     * NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
     */
    public class Problem17
    {
        public string Solve()
        {
            int totalLetters = 0;
            for (int i = 1; i <= 1000; i++)
            {
                totalLetters += countLetters(i.ToText());
            }
            return totalLetters.ToString();
        }

        public static int countLetters(string number)
        {
            Regex rgx = new Regex("[^a-z]");
            string strippedNumber = rgx.Replace(number, "");
            return strippedNumber.Length;
        }
    }

    public static class Problem17Extensions
    {
        public static string ToText(this int number)
        {
            switch (number)
            {
                case 0: return "";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                case 20: return "twenty";
                case 30: return "thirty";
                case 40: return "forty";
                case 50: return "fifty";
                case 60: return "sixty";
                case 70: return "seventy";
                case 80: return "eighty";
                case 90: return "ninety";
                case 1000: return "one thousand";
                default:
                    string result = "";
                    int hundreds = number / 100;
                    int hundredsRemainder = number % 100;
                    if (hundreds > 0)
                    {
                        result += hundreds.ToText() + " " + "hundred";
                        if (hundredsRemainder > 0) result += " and ";
                    }
                    if (hundredsRemainder < 21)
                    {
                        result += hundredsRemainder.ToText();
                    }
                    else
                    {
                        int ones = number % 10;
                        int tens = hundredsRemainder - ones;
                        result += tens.ToText();
                        result += ones.ToText();
                    }
                    return result;
            }
        }
    }

}
