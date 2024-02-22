// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. 
// If a string is longer than the other, append the additional letters onto the end of the merged string.

//My solution
// var mergeAlternately = function(word1, word2) {
//     let totalLength = word1.length + word2.length;
//     let l1 = 0;
//     let l2 = 0;
//     let mergedString = "";
//     while(totalLength>0){
//        if(word1[l1] && word2[l2]){
//            mergedString = mergedString.concat(word1[l1],word2[l2]);
//        }else if(word1[l1]){
//            mergedString = mergedString.concat(word1[l1])
//        }else if(word2[l2]){
//            mergedString = mergedString.concat(word2[l2])
//        }
//        l1++;
//        l2++;
//        totalLength--;
//     }
//     return mergedString;
// };

//Better solution
var mergeAlternately = function(word1, word2) {
    let result = '';
     for (let i = 0; i < Math.max(word1.length, word2.length); i++) {
       if (i < word1.length) result += word1[i];
       if (i < word2.length) result += word2[i];
     }
     return result;
   };


console.log(mergeAlternately("abcdefghij","pqrst"))
