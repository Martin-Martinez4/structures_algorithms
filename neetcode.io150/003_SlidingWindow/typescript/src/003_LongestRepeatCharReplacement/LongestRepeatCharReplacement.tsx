/* 
    You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.

    Return the length of the longest substring containing the same letter you can get after performing the above operations.

    Example 1:

        Input: s = "ABAB", k = 2
        Output: 4
        Explanation: Replace the two 'A's with two 'B's or vice versa.
    Example 2:

        Input: s = "AABABBA", k = 1
        Output: 4
        Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
        The substring "BBBB" has the longest repeating letters, which is 4.
    */

function characterReplacement(s: string, k: number) {

    let trackerObject: {[key: string]: number} = {};
    let result = 0;
    let left = 0;
    let maxLength = 0;

    for (let i = 0; i < s.length; i++) {

        if(trackerObject[s[i]] !== undefined){

            trackerObject[s[i]] = 1 + trackerObject[s[i]]
        }else{

            trackerObject[s[i]] = 1
        }


        maxLength = Math.max(maxLength, trackerObject[s[i]])

        if(i - left + 1 - maxLength > k){

            trackerObject[s[left]] -= 1;
            left += 1;
    
        }
        
        result = Math.max(result, i - left + 1);
    
       
    }

    return result;

};