using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    class LetterCombination
    {
        IList<string> result = new List<string>(81);

        IDictionary<char, List<char>> mappings = new Dictionary<char, List<char>>()
        {
            {'2', new List<char> {'a', 'b', 'c'} },
            {'3', new List<char> {'d', 'e', 'f'} },
            {'4', new List<char> {'g', 'h', 'i'} },
            {'5', new List<char> {'j', 'k', 'l'} },
            {'6', new List<char> {'m', 'n', 'o'} },
            {'7', new List<char> {'p', 'q', 'r', 's'} },
            {'8', new List<char> {'t', 'u', 'v'} },
            {'9', new List<char> {'w', 'x', 'y', 'z'} },
        };

        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0)
            {
                return this.result;
            }

            LetterCombRecurse(digits, 0, string.Empty);
            return this.result;
        }

        private void LetterCombRecurse(string digits, int curr, string combination)
        {
            if (curr >= digits.Length)
            {
                this.result.Add(combination);
                return;
            }

            foreach (var item in this.mappings[digits[curr]])
            {
                this.LetterCombRecurse(digits, curr + 1, combination + item);
            }
        }
    }
}
