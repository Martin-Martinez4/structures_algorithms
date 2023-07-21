
using System.Collections.Generic;

namespace SlidingWindow
{
    public partial class Solutions
    {
        /*
            Given a string s, find the length of the longest 
            substring
            without repeating characters.

            Example 1:

            Input: s = "abcabcbb"
            Output: 3
            Explanation: The answer is "abc", with the length of 3.
            Example 2:

            Input: s = "bbbbb"
            Output: 1
            Explanation: The answer is "b", with the length of 1.
            Example 3:

            Input: s = "pwwkew"
            Output: 3
            Explanation: The answer is "wke", with the length of 3.
            Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
            

            Constraints:

            0 <= s.length <= 5 * 104
            s consists of English letters, digits, symbols and spaces.
        */
        public int LengthOfLongestSubstring(string s)
        {

            int maxLen = 0;
            int leftPntr = 0;
            int rightPntr = 0;

            HashSet<char> seenSoFar = new HashSet<char>();

            while (rightPntr < s.Length)
            {
                char leftChar = s[leftPntr];
                char rightChar = s[rightPntr];

                if (seenSoFar.Contains(rightChar))
                {
                    seenSoFar.Remove(leftChar);
                    leftPntr++;
                }
                else
                {
                    seenSoFar.Add(rightChar);
                    maxLen = Math.Max(maxLen, seenSoFar.Count);
                    rightPntr++;

                }
            }

            return maxLen;

        }
    }
}