using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestIdeas
{
    public class AtoI
    {
        private static int MAX_INT = 214748364;

        private static int MIN_INT = -214748364;

        public int MyAto2i(string s)
        {
            int result = 0;
            bool numberStarted = false, inValid = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (!numberStarted && s[i] == ' ')
                {
                    continue;
                }
                else if (numberStarted && s[i] == ' ')
                {
                    inValid = true;
                }

                if (numberStarted && (s[i] < '0' || s[i] > '9'))
                {
                    inValid = true;
                }

                if (inValid) return result;

                numberStarted = true;
                // check the overflow limit
                int curr_digit = s[i] - '0';
                if (result >= MAX_INT && curr_digit > 7)
                {
                    return MAX_INT * 10 + 7;
                }
                else if (result <= MIN_INT && curr_digit < -8) {
                    return MIN_INT * 10 - 8;
                }

                result = result * 10 + curr_digit;
            }

            return result;
        }

        public int MyAtoi(string s)
        {
            bool isNegative = false;
            int result = 0;
            var state = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (state)
                {
                    case 0:
                        // Not started
                        if (s[i] == ' ')
                        {
                            continue;
                        }
                        if (s[i] >= '0' || s[i] <= '9' || s[i] == '+' || s[i] == '-')
                        {
                            state = 1;
                            if (s[i] >= '0' || s[i] <= '9')
                                result = s[i] - '0';
                            if (s[i] == '-')
                            {
                                isNegative = true;
                            }
                        }
                        else
                        {
                            state = 2;
                        }
                        break;
                    case 1:
                        // Started
                        if (s[i] < '0' || s[i] > '9')
                        {
                            state = 2;
                        }
                        else
                        {
                            int curr_digit = s[i] - '0';
                            if (result >= MAX_INT && curr_digit > 7)
                            {
                                return MAX_INT * 10 + 7;
                            }
                            else if (result <= MIN_INT && curr_digit < -8)
                            {
                                return MIN_INT * 10 - 8;
                            }

                            if (isNegative)
                            {
                                result = result * 10 - curr_digit;
                            }
                            else
                            {
                                result = result * 10 + curr_digit;
                            }
                        }
                        break;
                    case 2:
                        // Invalid
                        return result;
                }
            }

            return result;
        }
    }
}
