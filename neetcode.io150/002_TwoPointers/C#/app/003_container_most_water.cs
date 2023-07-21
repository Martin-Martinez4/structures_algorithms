/*
You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the maximum amount of water a container can store.

Notice that you may not slant the container.

Example 1:


Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
Example 2:

Input: height = [1,1]
Output: 1
*/


namespace TwoPointers
{
    public static partial class Solutions
    {
        public static int MaxArea(int[] height)
        {
            int leftPntr = 0;
            int rightPntr = height.Length - 1;
            int maxArea = 0;
            int currentArea;

            while (leftPntr < rightPntr)
            {
                currentArea = Math.Min(height[leftPntr], height[rightPntr]) * (rightPntr - leftPntr);

                maxArea = Math.Max(currentArea, maxArea);

                if(height[leftPntr] > height[rightPntr])
                {
                    rightPntr--;
                }
                else
                {
                    leftPntr++;
                }
            }

            return maxArea;
        }

        // Storing the values height[leftPntr] and height[rightPntr] made it faster on leetcode.  
        public static int MaxArea2(int[] height)
        {
            int leftPntr = 0;
            int rightPntr = height.Length - 1;
            int maxArea = 0;
            int currentArea;

            while (leftPntr < rightPntr)
            {
                int leftValue = height[leftPntr];
                int rightValue = height[rightPntr];
                currentArea = Math.Min(leftValue, rightValue) * (rightPntr - leftPntr);

                maxArea = Math.Max(currentArea, maxArea);

                if(leftValue > rightValue)
                {
                    rightPntr--;
                }
                else
                {
                    leftPntr++;
                }
            }

            return maxArea;
        }
    }
}