using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas.Medium
{
    class StartAndEndIndex
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var start = SearchStart(nums, target);
            if (start == -1) return new int[] { -1, -1 };
            var end = SearchEnd(nums, target);
            return new int[] { start, end };
        }

        private int SearchStart(int[] nums, int target)
        {
            int s = 0, e = nums.Length - 1;

            while (s <= e)
            {
                int mid = s + (e - s) / 2;
                if (nums[mid] == target && (mid > 0 ? nums[mid - 1] != target : true))
                {
                    return mid;
                }
                else if (nums[mid] >= target)
                {
                    e = mid - 1;
                }
                else
                {
                    s = mid + 1;
                }
            }

            return -1;
        }

        private int SearchEnd(int[] nums, int target)
        {
            int s = 0, e = nums.Length - 1;

            while (s <= e)
            {
                int mid = s + (e - s) / 2;
                if (nums[mid] == target && (mid < nums.Length - 1 ? nums[mid + 1] != target : true))
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    e = mid - 1;
                }
                else
                {
                    s = mid + 1;
                }
            }

            return -1;
        }
    }
}
