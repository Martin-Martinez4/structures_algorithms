/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 
*/ 

function isAnagram(s: string, t: string): boolean {

    if(s.length !== t.length){

        return false
    }

    const a =  s.split('').sort();
    const b =  t.split('').sort();

    for(let i = 0; i < a.length; i++){

        if(a[i] !== b[i]){

            return false
        }

    }

    return true
    
}