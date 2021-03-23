using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    class RemoveDuplicate
    {
        public int RemoveElement(int[] nums, int val)
        {
            int currIdx = 0;

            for (int i = 0; i< nums.Length; ++i)
            {
                if (nums[i] == val)
                {
                    continue;
                }
                else
                {
                    nums[currIdx++] = nums[i];
                }
            }

            return currIdx;
        }
    }
}
