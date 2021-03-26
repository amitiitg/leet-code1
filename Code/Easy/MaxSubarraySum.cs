using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    class MaxSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = -10000000;
            int currSum = -10000000;

            for (int i = 0; i < nums.Length; ++i)
            {
                if (currSum < 0)
                {
                    currSum = nums[i];
                }
                else
                {
                    currSum += nums[i];
                }

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                }
            }

            return maxSum;
        }
    }
}
