/*
Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

You must write an algorithm that runs in O(n) time.

Example 1:

Input: nums = [100,4,200,1,3,2]
Output: 4
Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
Example 2:

Input: nums = [0,3,7,2,5,8,4,6,0,1]
Output: 9
*/

public class Solution
{
    // Cna probalby combine the two loops
    public int LongestConsecutive(int[] nums)
    {
        // Convert the array into a set
        // First loop check if the current number has a left nieghbor by checking for a number equal to it-1 in the set.  
        // The numbers that do not have it are the beginning of a sequence.  
        // Then look for numbers that are one higher in the set

        Hashset<int> numsSet = new Hashset<List<int>>(nums);
        List<int> beginningOfSequence = List<int>();
        list<List<int>> sequences = List<List<int>>();

        foreach (int num in nums)
        {
            if (!numsSet.Contains(num - 1))
            {
                beginningOfSequence.Add(num);
            }
        }

        maxLength = 0;

        foreach (int num in beginningOfSequence)
        {
            sequences.Add(new List<int>() { num });
            int nextNumberInSequence = num + 1;

            while (numsSet.Contains(nextNumberInSequence))
            {
                sequences[sequences.Count - 1].Add(nextNumberInSequence);

                nextNumberInSequence++;
            }

            if( sequences[sequences.Count - 1].Count > maxLength)
            {
                maxLength = sequences[sequences.Count - 1].Count;
            }
        }

        return maxLength;

    }

}
