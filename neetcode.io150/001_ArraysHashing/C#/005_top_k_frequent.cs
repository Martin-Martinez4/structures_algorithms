/*
Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

Example 1:

Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]
Example 2:

Input: nums = [1], k = 1
Output: [1]

1 <= nums.length <= 105
-104 <= nums[i] <= 104
k is in the range [1, the number of unique elements in the array].
It is guaranteed that the answer is unique.
*/

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {

        Dictionary<int, int> intTracker = new Dictionary<int, int>();
        int[] resultArray = new int[k];
        List<int>[] appearances = new List<int>[nums.Length + 1];
        for (int i = 0; i < appearances.Length; i++)
        {
            appearances[i] = new List<int>();
        }


        foreach (int num in nums)
        {
            if (intTracker.ContainsKey(num))
            {
                intTracker[num] += 1;
            }
            else
            {
                intTracker[num] = 1;
            }
        }

        foreach (var entry in intTracker)
        {
            appearances[entry.Value].Add(entry.Key);
        }

        int currentIndex = 0;

        for (int i = appearances.Length - 1; i >= 1; i--)
        {
            int elementsTobeAdded = appearances[i].Count;
            while (elementsTobeAdded > 0 || currentIndex >= k)
            {
                resultArray[currentIndex] = appearances[i][elementsTobeAdded - 1];
                elementsTobeAdded--;
                currentIndex++;
                if (currentIndex >= k)
                {
                    break;
                }
            }
            // If k elements have been added, break out of the loop
            if (currentIndex >= k)
            {
                break;
            }
        }

        return resultArray;

    }

    public int[] TopKFrequent2(int[] nums, int k) 
    {
        return nums.GroupBy(num => num)
        .OrderByDescending(num => num.Count())
        .Take(k)
        .Select(c => c.Key)
        .ToArray();
    }
}