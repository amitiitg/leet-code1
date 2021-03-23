using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    public class RomanToInt
    {
        public Dictionary<char, int> romanValues = new Dictionary<char, int>()
        {
            { 'I', 1},
            { 'V', 5 },
            { 'X', 10},
            { 'L', 50 },
            { 'C', 100},
            { 'D', 500},
            { 'M', 1000 },
        };

        public Dictionary<string, int> negativeValues = new Dictionary<string, int>()
        {
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },
            { "CD", 400},
            { "CM", 900 }
        };

        public int RomanNumberToInt(string roman)
        {
            int i = 0;
            int result = 0;
            while(i < roman.Length)
            {
                var twoRoman = roman.Substring(i, i < roman.Length - 1 ? 2 : 1);
                if (negativeValues.TryGetValue(twoRoman, out int value))
                {
                    result += value;
                    i += 2;
                }
                else
                {
                    result += romanValues[roman[i]];
                    ++i;
                }
            }

            return result;
        }
    }
}
