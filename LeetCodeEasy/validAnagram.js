// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
// typically using all the original letters exactly once.

//  Example 1:
// Input: s = "anagram", t = "nagaram"
// Output: true
// Example 2:
// Input: s = "rat", t = "car"
// Output: false

function isAnagram(s,t) {
    if(s.length !== t.length) return false;
    var lookup = {};
    for (let index = 0; index < s.length; index++) {
        let char = s[index];
        lookup[char] = (lookup[char] || 0) + 1;
    }
    for (let index = 0; index < t.length; index++) {
        let char = t[index];
        if(lookup[char]) 
           lookup[char]--;
        else
           return false;
    }
    return true;
}

console.log(isAnagram("anagram","nagaram"))
console.log(isAnagram("rat","car"))