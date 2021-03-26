using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    class ThreeSumClosest
    {
        public int ThreeSumClosest1(int[] nums, int target)
        {
            Array.Sort(nums);

            var result = nums[0] + nums[1] + nums[2];
            for (int i = 0; i < nums.Length; ++i)
            {
                var closest = Closest2SumToTarget(nums, i + 1, nums.Length - 1, target - nums[i]);
                if (closest != null)
                {
                    var cloestDiff = (closest.Value + nums[i] - target < 0) ? (closest.Value + nums[i] - target) * -1 : (closest.Value + nums[i] - target);
                    var targetDiff = (target - result < 0) ? (target - result) * -1 : (target - result);
                    if (cloestDiff < targetDiff)
                    {
                        result = closest.Value + nums[i];
                    }
                }
            }

            return result;
        }

        private int? Closest2SumToTarget(int[] nums, int start, int end, int target)
        {
            if (start >= end)
            {
                return null;
            }

            var closest2Sum = nums[start] + nums[end];
            while (start < end)
            {
                var diff = (nums[start] + nums[end] - target < 0) ? -1 * (nums[start] + nums[end] - target) : (nums[start] + nums[end] - target);
                var closest2SumDiff = (closest2Sum - target < 0) ? -1 * (closest2Sum - target) : (closest2Sum - target);

                if (diff < closest2SumDiff)
                {
                    closest2Sum = nums[start] + nums[end];
                }

                if (nums[start] + nums[end] > target)
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }

            return closest2Sum;
        }
    }
}
