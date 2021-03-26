using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas.Medium
{
    class _4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);

            int i = 0;
            List<IList<int>> result = new List<IList<int>>();
            while(i < nums.Length)
            {
                while (i > 0 && nums[i - 1] == nums[i]) i++;
                var res = ThreeSum(nums, i+1, target - nums[i]);
                foreach (var item in res)
                {
                    item.Add(nums[i]);
                }

                result.AddRange(res);
                i++;
            }

            return result;
        }

        private List<IList<int>> ThreeSum(int[] nums, int index, int target)
        {
            if (index >= nums.Length)
            {
                return new List<IList<int>>();
            }

            int i = index;
            List<IList<int>> result = new List<IList<int>>();
            while (i < nums.Length)
            {
                while (i > index && nums[i - 1] == nums[i]) i++;
                var res = TwoSum(nums, i + 1, target - nums[i]);
                foreach (var item in res)
                {
                    item.Add(nums[i]);
                }

                result.AddRange(res);
                i++;
            }

            return result;
        }

        private List<IList<int>> TwoSum(int[] nums, int index, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            int s = index, e = nums.Length - 1;
            while (s < e)
            {
                if (nums[s] + nums[e] == target)
                {
                    result.Add(new List<int>() { nums[s], nums[e] });
                    s++;
                    e--;
                    while (s < e && nums[s - 1] == nums[s]) s++;
                }
                else if (nums[s] + nums[e] > target)
                {
                    e--;
                    while (s < e && nums[e] == nums[e + 1]) e--;
                }
                else
                {
                    s++;
                    while (s < e && nums[s - 1] == nums[s]) s++;
                }
            }

            return result;
        }
    }
}
