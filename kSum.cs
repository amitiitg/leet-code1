using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    class kSum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            return kSumRecurse(nums, 4, 0, nums.Length - 1, target);
        }

        private IList<IList<int>> kSumRecurse(int[] nums, int k, int start, int end, int target)
        {
            if (k == 2)
            {
                return TwoSum(nums, start, end, target);
            }

            var res = new List<IList<int>>();
            for (int i = start; i < nums.Length; ++i)
            {
                var tmp = kSumRecurse(nums, k - 1, i + 1, nums.Length, target - nums[i]);
                foreach (var item in tmp)
                {
                    item.Add(nums[i]);
                }
                res.AddRange(tmp);
            }

            return res;
        }

        private IList<IList<int>> TwoSum(int[] nums, int start, int end, int target)
        {
            var result = new List<IList<int>>();

            while(start < end)
            {
                int curr_start = nums[start], curr_end = nums[end];
                if (nums[start] + nums[end] == target)
                {
                    result.Add(new List<int>() { nums[start], nums[end] });
                    start++;
                    while (nums[start] == curr_start) start++;
                }
                else if (nums[start] + nums[end] > target)
                {
                    end--;
                    while (nums[end] == curr_end) end--;
                }
                else
                {
                    start++;
                    while (nums[start] == curr_start) start++;
                }
            }

            return result;
        }
    }
}
