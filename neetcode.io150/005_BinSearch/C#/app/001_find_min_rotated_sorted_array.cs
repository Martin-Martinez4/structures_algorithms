
using System.Collections.Generic;

namespace BinSearch
{
    public partial class Solutions
    {
        /*
            Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,2,4,5,6,7] might become:

            [4,5,6,7,0,1,2] if it was rotated 4 times.
            [0,1,2,4,5,6,7] if it was rotated 7 times.
            Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].

            Given the sorted rotated array nums of unique elements, return the minimum element of this array.

            You must write an algorithm that runs in O(log n) time.
            
            Example 1:

            Input: nums = [3,4,5,1,2]
            Output: 1
            Explanation: The original array was [1,2,3,4,5] rotated 3 times.
            Example 2:

            Input: nums = [4,5,6,7,0,1,2]
            Output: 0
            Explanation: The original array was [0,1,2,4,5,6,7] and it was rotated 4 times.
            Example 3:

            Input: nums = [11,13,15,17]
            Output: 11
            Explanation: The original array was [11,13,15,17] and it was rotated 4 times. 
        */
        // Have a Left pointer, right pointer, and middle pointer as usual
        // If middle value is larger or equal to than left value search elements to the right of the middle.  else search to the left
        // Search left is the same as placing the left pointer and mid + 1
        // Search right is the same as placing the right pointer and mid
        // middle value is the potential result, if the current m is smaller than the current smallest which.  
        public int FindMin(int[] nums)
        {

            int leftPntr = 0;
            int rightPntr = nums.Length -1;

            while(leftPntr <= rightPntr)
            {
                int leftValue = nums[leftPntr];
                int rightValue = nums[rightPntr];

                if(leftValue <= rightValue)
                {
                    return leftValue;
                }

                int middlePntr = (rightPntr + leftPntr) /2;

                if(nums[middlePntr] >= leftValue)
                {
                    leftPntr = middlePntr + 1;
                }
                else
                {
                    rightPntr = middlePntr;
                }

            }

            return 0;

        }
    }
}