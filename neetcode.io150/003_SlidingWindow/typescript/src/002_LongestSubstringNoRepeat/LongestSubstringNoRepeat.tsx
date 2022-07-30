/* 
    Given a string s, find the length of the longest substring without repeating characters.

    Input: s = "abcabcbb"
    Output: 3
    Explanation: The answer is "abc", with the length of 3.

    Input: s = "pwwkew"
    Output: 3
    Explanation: The answer is "wke", with the length of 3.
    Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
    */

function lengthOfLongestSubstring(s: string) {

    let start = 0;
    let maxSubstring = 0;

    let trackerObject: {[key:string]: number} = {}

    for(let i = 0; i < s.length; i++){

        let rightChar = s[i];

        if (!(rightChar in trackerObject)) trackerObject[rightChar] = 0;

        trackerObject[rightChar] += 1

        while(trackerObject[rightChar] > 1){

            let leftChar = s[start];
            start += 1;

            if (leftChar in trackerObject) trackerObject[leftChar] -= 1;
            if (trackerObject[leftChar] === 0) delete trackerObject[leftChar];

        }

        maxSubstring = Math.max(maxSubstring, i - start + 1);


    }

    return maxSubstring

};

console.log(lengthOfLongestSubstring("abcabcbb"))
console.log(lengthOfLongestSubstring("pwwkew"))
console.log(lengthOfLongestSubstring("aab"))

