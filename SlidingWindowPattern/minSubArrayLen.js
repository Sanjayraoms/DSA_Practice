// Write a function called minSubArrayLen which accepts two parameters - 
// an array of positive integers and a positive integer.
// This function should return the minimal length of a contiguous subarray of which the sum is 
// greater than or equal to the integer passed to the function. If there isn't one, return 0 instead.
//console.log(minSubArrayLen([2,3,1,2,4,3], 7)) // 2 -> because [4,3] is the smallest subarray
//console.log(minSubArrayLen([2,1,6,5,4], 9)) // 2 -> because [5,4] is the smallest subarray
console.log(minSubArrayLen([3,1,7,11,2,9,8,21,62,33,19], 52)) // 1 -> because [62] is greater than 52
console.log(minSubArrayLen([1,4,16,22,5,7,8,9,10],39)) // 3
console.log(minSubArrayLen([1,4,16,22,5,7,8,9,10],55)) // 5
console.log(minSubArrayLen([4, 3, 3, 8, 1, 2, 3], 11)) // 2
console.log(minSubArrayLen([1,4,16,22,5,7,8,9,10],95)) // 0

//My solution
// function minSubArrayLen(arr,num) {
//     var total = 0;
//     for (let index = 0; index < arr.length; index++) {
//         total += arr[index];        
//     }
//     if(total < num) return 0;
//     var total1 = 0;
//     var total2 = 0;
//     while (arr.length > 0) {
//         var startPos = 0;
//         var endPos = arr.length - 1;
//         total1 = total - arr[startPos];
//         total2 = total - arr[endPos];
//         if(total1 == total2 && arr.length ==1) break;
//         if ((total1 >= num && total1 > total2) || total1 == total2) {
//             startPos++;
//             arr = arr.slice(startPos);
//             total = total1;
//         }else if (total2 >= num && total2 > total1) {
//             arr = arr.slice(0,endPos);
//             endPos--;
//             total = total2;
//         }else{
//             break;
//         }
//     }
//     return arr.length;
// }

//Better solution

function minSubArrayLen(nums,sum) {
    let total = 0;
    let start = 0;
    let end = 0;
    let minLen = Infinity;

    while (start < nums.length) {
        if (total < sum && end < nums.length) {
            total += nums[end];
            end++;
        }else if (total >= sum) {
            minLen = Math.min(minLen,end-start);
            total -=nums[start];
            start++;
        }else{
            break;
        }
    }
    return minLen === Infinity?0:minLen;
}