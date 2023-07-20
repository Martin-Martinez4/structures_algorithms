
using System.Collections.Generic;
public class Solution
{
    // Faster
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> lookForDups = new HashSet<int>();

        foreach (var num in nums)
        {
            if (lookForDups.Contains(num))
            {
                return true;
            }
            else
            {
                lookForDups.Add(num);
            }
        }

        return false;
    }

    // Less memory used
    public bool ContainsDuplicate2(int[] nums)
    {

        Array.Sort(nums);
        int oneAhead;

        for (int i = 0; i < nums.Length; i++)
        {
            if(i >= nums.Length){
                return false;
            }

            oneAhead = i+1;

            if(nums[i] == nums[oneAhead])
            {
                return true;
            }
        }

        return false;
    }

}