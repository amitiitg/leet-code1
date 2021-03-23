using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;

            for (int i = 0; i < height.Length; ++i)
            {
                for (int j = i+1; j < height.Length; ++j)
                {
                    var area = (j - i) * (height[i] < height[j] ? height[i] : height[j]);
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }

            return maxArea;
        }

        public int MaxArea2(int[] height)
        {
            int i = 0, j = height.Length - 1;
            int maxArea = 0;

            while(i != j)
            {
                var area = ((height[i] < height[j]) ? height[i] : height[j]) * (j - i);
                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return maxArea;
        }
    }
}
