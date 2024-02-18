//Write a function called macSubarraySum which accepts an array of integers and
//a number called n. The function should calculate the maximum sum of n consecutive
//elements in the array
function maxSubarraySum(arr,num) {
    if (num > arr.length) return null;
    var maxSum = 0;
    for (let index = 0; index < num; index++) {
        maxSum += arr[index];        
    }

    var tempSum = maxSum;
    for (let index = num; index < arr.length; index++) {
        tempSum = tempSum - arr[index-num] + arr[index];
        maxSum = Math.max(tempSum,maxSum);
    }
    return maxSum;
}

console.log(maxSubarraySum([1,2,5,2,8,1,5],2))
console.log(maxSubarraySum([1,2,5,2,8,1,5],4))