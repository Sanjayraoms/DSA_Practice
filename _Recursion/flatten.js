// Write a recursive function called flatten which accepts an array of arrays and returns 
// a new array with all values flattened.

console.log(flatten([1, 2, 3, [4, 5] ])) // [1, 2, 3, 4, 5]
console.log(flatten([1, [2, [3, 4], [[5]]]])) // [1, 2, 3, 4, 5]
console.log(flatten([[1],[2],[3]])) // [1,2,3]
console.log(flatten([[[[1], [[[2]]], [[[[[[[3]]]]]]]]]])) // [1,2,3

function flatten(oldArr) {
    var newArr = [];
    for (let index = 0; index < oldArr.length; index++) {
        if (Array.isArray(oldArr[index])) {
            newArr = newArr.concat(flatten(oldArr[index]));
        }else{
            newArr.push(oldArr[index]);
        }       
    }
    return newArr;
}