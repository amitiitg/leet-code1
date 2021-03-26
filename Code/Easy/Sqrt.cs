using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas.Easy
{
    class Sqrt
    {
        public int MySqrt(int x)
        {
            int s = 0, e = x;
            while(s <= e)
            {
                int mid = s + (e - s) / 2;
                long num = mid * mid;
                if (num == x) return mid;
                if (num < x)
                {
                    // always increase mid.
                    s = mid + 1;
                }
                else
                {
                    // always decrease mid.
                    e = mid - 1;
                }
            }

            return e;
        }
    }
}
