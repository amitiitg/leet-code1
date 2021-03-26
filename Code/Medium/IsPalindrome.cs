using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    public class IsPalindrome
    {
        private static int INT_MAX = 2147483647;

        public bool IsPalindromeInt(int x)
        {
            int reversedX = 0, originalX = x;
            if (x < 0)
            {
                return false;
            }

            while (x != 0)
            {
                if (reversedX > INT_MAX / 10 || (reversedX == INT_MAX / 10 && x > 7))
                {
                    return false;
                }

                reversedX = (reversedX * 10) + (x % 10);
                x /= 10;
            }

            return (reversedX == originalX);
        }
    }
}
