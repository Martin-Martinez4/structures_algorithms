/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
*/

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<string, int> letterTracker = new Dictionary<string, int>();

        foreach (string letter in s)
        {
            if (letterTracker.ContainsKey)
            {
                letterTracker[letter] += 1;
            }
            else
            {
                letterTracker[letter] = 1;
            }
        }

        foreach (string letter in t)
        {
            if (letterTracker.ContainsKey)
            {
                letterTracker[letter] -= 1;
                if (letterTracker[letter] < 0)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        foreach (KeyValuePair<string, string> entry in letterTracker)
        {
            if (entry.Value != 0)
            {
                return false;
            }
        }

        return true;
    }
    public bool IsAnagram2(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        String.Concat(s.OrderBy(c => c));
        String.Concat(t.OrderBy(c => c));

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != t[i])
            {
                return false;
            }
        }

        return true;
    }

    // Best but less scalable
    // Only english and alphabet support
    public bool IsAnagram3(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] map = new int[26];

        // Make the charcode of 'a' be zero
        int charCodeOfa = (int)'a';

        foreach(char character in s)
        {
            map[(int)character - charCodeOfa]++;
        }

        foreach(char character in t)
        {
            map[(int)character - charCodeOfa]--;
        }

        return !map.Any(el => el != 0);

    }
}