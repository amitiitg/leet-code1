using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    public class RemoveDuplicateFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int newLength = 0;
            for (int i = 0; i< nums.Length; ++i)
            {
                if (newLength == 0 || nums[newLength - 1] != nums[i])
                {
                    //new number
                    nums[newLength] = nums[i];
                    newLength++;
                }
            }

            return newLength;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    public class RemoveDuplicateFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int newLength = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (newLength == 0 || nums[newLength - 1] != nums[i])
                {
                    //new number
                    nums[newLength] = nums[i];
                    newLength++;
                }
            }

            return newLength;
        }
    }
}
