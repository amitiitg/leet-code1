using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    public class ReverseDigits
    {
        private static int INT_MAX = 2147483647;

        private static int INT_MIN = -2147483648;

        public int Reverse(int x)
        {
            int reversedX = 0;
            var isNegative = (x < 0);

            while (x != 0)
            {
                if (!isNegative && (reversedX > INT_MAX/10 || (reversedX == INT_MAX/10 && x > 7)))
                {
                    return 0;
                }

                if (isNegative && (reversedX < INT_MIN/10 || (reversedX == INT_MIN/10 && x < -8)))
                {
                    return 0;
                }

                reversedX = (reversedX * 10) + (x % 10);
                x /= 10;
            }

            return reversedX;
        }

    }
}
