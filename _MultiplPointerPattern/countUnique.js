//Implement a function called countUniqueValues, which accepts a sorted array, and counts the unique
//values in the array. There can be negative numbers in the array, but it will always be sorted.
function countUniqueValues(sortedArray) {
    let i = 0;
    let j = 1;
    while (j<sortedArray.length) {
        if (sortedArray[i] == sortedArray[j]) {
            j++;
        }else{
            i++;
            sortedArray[i] = sortedArray[j]
            j++;
        }
    }
    if (i>0) {
        return i+1;
    }
    return i; 
}

//console.log(countUniqueValues([1,2,3,4,4,4,7,7,12,12,13]))
//console.log(countUniqueValues([1,1,1,1,1,2]))
console.log(countUniqueValues([-2,-1,-1,0,1]))