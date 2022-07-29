/* 
    Given an array of strings strs, group the anagrams together. You can return the answer in any order.

    An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

    Input: strs = ["eat","tea","tan","ate","nat","bat"]
    Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
*/

// Create an array for each input each index will be 
// at the end check if hash is equal to any other hash


function groupAnagrams(strs: string[]) {

    let newObject: Partial<{[key: string]: [string]}> = {}

    for(let i = 0; i < strs.length; i++){

        let tempString = strs[i].split("").sort().join("");
        
        if(newObject[tempString] === undefined){
            newObject[tempString] = [strs[i]]
        }else{
            newObject[tempString]?.push(strs[i])
        }
        
    }

    
    return Object.values(newObject)

};


// From neet code
// Similar to what I was thinking craeate a 26 long array for each word, the index corresponds to the charcode of the letter
// increase the index of the array by ones for each time the letter appears
// What I did not know: arrays can be keys in the object
const CODES:{[key: string]: number} = {
    a: 0,
    b: 1,
    c: 2,
    d: 3,
    e: 4,
    f: 5,
    g: 6,
    h: 7,
    i: 8,
    j: 9,
    k: 10,
    l: 11,
    m: 12,
    n: 13,
    o: 14,
    p: 15,
    q: 16,
    r: 17,
    s: 18,
    t: 19,
    u: 20,
    v: 21,
    w: 22,
    x: 23,
    y: 24,
    z: 25,
};


function hashWord(word :string) {
    const hash = new Array(26).fill(0);
    for (const ch of word) {
        ++hash[CODES[ch]];
    }
    return hash.toString();
}

function groupAnagrams2(words: string[]): string[][] {

    const map = Object.create(null);

    for (const word of words) {

        const hash = hashWord(word);

        if (!(hash in map)) {
            map[hash] = [];
        }
        map[hash].push(word);
    }

    const groups = [];
    for (const key in map) {
        groups.push(map[key]);
    }
    return groups;
}

groupAnagrams( ["eat","tea","tan","ate","nat","bat"])
groupAnagrams2( ["eat","tea","tan","ate","nat","bat"])



