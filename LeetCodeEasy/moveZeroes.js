// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
// Note that you must do this in-place without making a copy of the array.

// Example 1:
// Input: nums = [0,1,0,3,12]
// Output: [1,3,12,0,0]
// Example 2:
// Input: nums = [0]
// Output: [0]

function moveZeroes(arr) {
    //My first lame solution
    // var swaps;
    // for (let index = 0; index < arr.length; index++) {
    //     if (arr[index] === 0) {
    //         let zIndex = index;
    //         swaps = false;
    //         for (let j = zIndex + 1; j < arr.length; j++) {
    //             if (arr[j]!==0) {
    //                 let temp = arr[j];
    //                 arr[j] = arr[zIndex];
    //                 arr[zIndex] = temp;
    //                 zIndex = j;
    //                 swaps = true;
    //             }
    //         }
    //     }
    //     if (swaps === false) {
    //         break;
    //     }
    // }
    var pointZero = 0;
    var pointNonZero = 0;
    while (pointNonZero < arr.length) {
        if (arr[pointZero] === 0 && arr[pointNonZero] !== 0) {
            let temp = arr[pointZero];
            arr[pointZero] = arr[pointNonZero]
            arr[pointNonZero] = temp;
            pointZero++;
        }else if(arr[pointZero] !== 0 && arr[pointNonZero] !== 0 )
            pointZero++;
        pointNonZero++;
    }
    return arr;
}

//console.log(moveZeroes([0,1,0,3,12]));
//console.log(moveZeroes([1,0]))
console.log(moveZeroes([1,0,1]))