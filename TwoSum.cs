using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    public class Solution
    {
        public int[] TwoSum(List<int> nums, int target)
        {
            nums.Sort();

            int firstIdx = 0, secondIdx = nums.Count - 1;
            while(firstIdx < secondIdx)
            {
                if (nums[firstIdx] + nums[secondIdx] == target)
                {
                    return new int[] { firstIdx, secondIdx };
                }
                else if(nums[firstIdx] + nums[secondIdx] > target)
                {
                    --secondIdx;
                }
                else
                {
                    ++firstIdx;
                }
            }

            return Array.Empty<int>();
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, List<int>> number2indexmapping = new Dictionary<int, List<int>>(nums.Length);

            for (int i = 0; i < nums.Length; ++i)
            {
                if (!number2indexmapping.TryGetValue(nums[i], out List<int> indices))
                {
                    number2indexmapping[nums[i]] = new List<int>();
                }

                number2indexmapping[nums[i]].Add(i);
            }

            for (int i = 0; i < nums.Length; ++i)
            {
                if (number2indexmapping.TryGetValue(target - nums[i], out List<int> indices))
                {
                    if (i != indices[0])
                    {
                        return new int[] { i, indices[0] };
                    }
                }
            }

            return new int[] { };
        }
    }
}
