using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    class BSAndFindIndex
    {
        public int SearchInsert(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (target > nums[mid])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return l;
        }
        // nums = [1,3,5,6], target = 2
        // l = 0, r = 3, m = 1
        // l = 0, r = 0, m = 0
        // l = 1, r = 0, 
    }
}
