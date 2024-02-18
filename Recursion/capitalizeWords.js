// Write a recursive function called capitalizeWords. 
// Given an array of words, return a new array containing each word capitalized.

let words = ['i', 'am', 'learning', 'recursion'];
console.log(capitalizedWords(words)); // ['I', 'AM', 'LEARNING', 'RECURSION']

function capitalizedWords(arr) {
    var newArr = [];
    if(arr.length === 0) return newArr;
    newArr.push(arr[0].toUpperCase())
    return newArr.concat(capitalizedWords(arr.slice(1)));
}