using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas.Easy
{
    class Climbstairs
    {
        public int ClimbStairs1(int n)
        {
            if (n < 3) return n;
            List<int> memoized = new List<int>(3);
            memoized.Add(1);
            memoized.Add(2);
            for (int i = 2; i < n; ++i)
            {
                memoized.Add(-1);
            }

            for (int i = 2; i < n; ++i)
            {
                memoized[i] = memoized[i - 1] + memoized[i - 2];
            }

            return memoized[n - 1];
        }
    }
}
