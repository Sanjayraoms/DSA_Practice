// Write a function called findLongestSubstring, which accepts a string and returns the
// length of the longest substring with all distinct characters.

// console.log(findLongestSubstring('')) // 0
// console.log(findLongestSubstring('rithmschool')) // 7
console.log(findLongestSubstring('thisisawesome')) // 6
console.log(findLongestSubstring('thecatinthehat')) // 7
console.log(findLongestSubstring('bbbbbb')) // 1
console.log(findLongestSubstring('longestsubstring')) // 8
console.log(findLongestSubstring('thisishowwedoit')) // 6
//My falied attempt
// function findLongestSubstring(str) {
//     var lookup = {};
//     var substr = "";
//     var longestStr = "";
//     for (let index = 0; index < str.length; index++) {
//         if (lookup[str[index]]) {
//             if(substr.length > longestStr.length) longestStr = substr;
//             lookup = {};
//             substr = substr.substring(1);
//         }else{
//             lookup[str[index]] = (lookup[str[index]] || 0) + 1;
//         }
//         substr = substr.concat(str[index]);      
//     }
//     return longestStr.length;
// }

function findLongestSubstring(str) {
    let longest = 0;
    let start = 0;
    let seen ={};
    for (let index = 0; index < str.length; index++) {
        let char = str[index];
        if (seen[char]) {
            start = Math.max(start,seen[char]);
        }
        longest = Math.max(longest, index-start+1);
        seen[char] = index+1;       
    }
    return longest;
}