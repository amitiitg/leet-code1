using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length; ++i)
            {
                // fix target.
                int target = -1 * nums[i];
                if (nums[i] < 0)
                {
                    break;
                }

                if (i > 0 && nums[i] == nums[i-1])
                {
                    continue;
                }

                var res = TwoSum(nums, 0, nums.Length - 1, target, i);
                foreach (var item in res)
                {
                    result.Add(item);
                }

            }

            return result;
        }

        private IList<List<int>> TwoSum(int[] nums, int start, int end, int target, int currIndex)
        {
            var result = new List<List<int>>();
            while (start < end)
            {
                if (nums[start] + nums[end] == target)
                {
                    result.Add(new List<int>(3) { nums[currIndex], nums[start], nums[end] });
                    start++;
                    while (start > 0 && start < nums.Length && nums[start - 1] == nums[start]) start++;
                }

                if (nums[start] + nums[end] > target)
                {
                    start++;
                    while (start > 0 && start < nums.Length && nums[start - 1] == nums[start]) start++;
                }
                else
                {
                    end--;
                    while (end > 0 && end < nums.Length && nums[end + 1] == nums[end]) end--;
                }
            }

            return result;
        }
    }
}
