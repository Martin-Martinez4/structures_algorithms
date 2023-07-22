
namespace BinSearch
{
    public partial class Solutions
    {
        /*
            There is an integer array nums sorted in ascending order (with distinct values).

            Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].

            Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

            You must write an algorithm with O(log n) runtime complexity.

            Example 1:

            Input: nums = [4,5,6,7,0,1,2], target = 0
            Output: 4
            Example 2:

            Input: nums = [4,5,6,7,0,1,2], target = 3
            Output: -1
            Example 3:

            Input: nums = [1], target = 0
            Output: -1
            

            Constraints:

            1 <= nums.length <= 5000
            -104 <= nums[i] <= 104
            All values of nums are unique.
            nums is an ascending array that is possibly rotated.
            -104 <= target <= 104
        */
        /*
            - Do binary search for the most part
            - Start the 
        */
        public int Search(int[] nums, int target)
        {
            int leftPntr = 0;
            int rightPntr = nums.Length - 1;

            while (leftPntr <= rightPntr)
            {
                int middlePntr = (leftPntr + rightPntr) / 2;
                int middleValue = nums[middlePntr];
                int leftValue = nums[leftPntr];
                int rightValue = nums[rightPntr];

                if (nums[middlePntr] == target)
                {
                    return middlePntr;
                }

                if (middleValue == target)
                {
                    return middlePntr;
                }
                else if (leftValue <= middleValue)
                {
                    if (target > middleValue || target < leftValue)
                        leftPntr = middlePntr + 1;
                    else rightPntr = middlePntr - 1;
                }
                else
                {
                    if (target < middleValue || target > rightValue)
                        rightPntr = middlePntr - 1;
                    else leftPntr = middlePntr + 1;
                }

            }

            return -1;
        }
    }
}