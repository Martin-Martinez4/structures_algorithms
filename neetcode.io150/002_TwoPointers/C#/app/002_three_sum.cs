/*
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation: 
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
The distinct triplets are [-1,0,1] and [-1,-1,2].
Notice that the order of the output and the order of the triplets does not matter.
Example 2:

Input: nums = [0,1,1]
Output: []
Explanation: The only possible triplet does not sum up to 0.
Example 3:

Input: nums = [0,0,0]
Output: [[0,0,0]]
Explanation: The only possible triplet sums up to 0.
*/
using System;
using System.Collections.Generic;

namespace TwoPointers
{
    public static partial class Solutions
    {
        public static List<IList<int>> ThreeSum(int[] nums)
        {

            // Sort the Array
            // Create a left pointer that is one ahead of the current i and right pointer that is at the end of the array.  
            // Add i + L + R  if sum is greater move right left, if it is lesser move left right.  
            // If zero L++ R--
            // If elements are repeated skip

            Array.Sort(nums);

            List<IList<int>> results = new List<IList<int>>() { };

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] > 0)
                {
                    break;
                }
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int leftPntr = i + 1;
                int rightPntr = nums.Length - 1;

                while (leftPntr < rightPntr)
                {
                    int threeSum = nums[i] + nums[leftPntr] + nums[rightPntr];

                    if (threeSum > 0)
                    {
                        rightPntr--;
                    }
                    else if (threeSum < 0)
                    {
                        leftPntr++;
                    }
                    else
                    {
                        results.Add(new List<int>() { nums[i], nums[leftPntr], nums[rightPntr] });
                        leftPntr++;
                        rightPntr--;

                        while (nums[leftPntr] == nums[leftPntr - 1] && leftPntr < rightPntr)
                        {
                            // Avoid dups of the leftPntr
                            leftPntr++;
                        }
                    }
                }
            }

            return results;

        }
    }
}