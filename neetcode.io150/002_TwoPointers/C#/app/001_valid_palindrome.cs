/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a pal
*/

using System.Text.RegularExpressions;

namespace TwoPointers
{
    public static partial class Solutions
    {
        // Slower than others
        public static bool IsPalindrome(string s)
        {
            var sRegexed = Regex.Replace(s, "[^a-zA-Z]", String.Empty);

            int j = sRegexed.Length - 1;
            for (int i = 0; i < j; i++)
            {
                if (char.ToLower(sRegexed[i]) != char.ToLower(sRegexed[j]))
                {
                    return false;
                }

                j--;

            }
            return true;
        }
    }
}