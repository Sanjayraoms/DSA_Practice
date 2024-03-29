// Write a function called isSubsequence which takes in two strings and checks whether the characters in the first string 
// form a subsequence of the characters in the second string. In other words, the function should check whether the characters 
// in the first string appear somewhere in the second

console.log(isSubsequence('hello', 'hello world')); // true
console.log(isSubsequence('sing', 'sting')); // true
console.log(isSubsequence('abc', 'abracadabra')); // true
console.log(isSubsequence('abc', 'acb')); // false (order matters)

function isSubsequence(str1,str2) {
    var str1Index = 0;
    var str2Index = 0;
    while (str2Index < str2.length) {
        if (str1[str1Index] === str2[str2Index]) {
            str1Index++;
            str2Index++;
        }else{
            str2Index++;
        }
        if (str1Index === str1.length) {
            return true;
        }
    }
    return false;
}