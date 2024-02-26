// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, 
// or -1 if needle is not part of haystack.
// Example 1:

// Input: haystack = "sadbutsad", needle = "sad"
// Output: 0
// Explanation: "sad" occurs at index 0 and 6.
// The first occurrence is at index 0, so we return 0.
// Example 2:

// Input: haystack = "leetcode", needle = "leeto"
// Output: -1
// Explanation: "leeto" did not occur in "leetcode", so we return -1.

function firstOccurence(needle,haystack) {
    if(needle.length > haystack.length) return -1;
    for (let index = 0; index <= haystack.length - needle.length; index++) {
        let startIndex = 0;
        while(startIndex < needle.length && haystack.charAt(index+startIndex)===needle.charAt(startIndex)){
            startIndex++;
        }
        if (startIndex === needle.length) {
            return index;
        }
    }
    return -1;
}
//Better solution is KMP algorithm.
console.log(firstOccurence("sad","butsad"))
console.log(firstOccurence("leeto","leetcode"))