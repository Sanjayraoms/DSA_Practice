function getDigit(num,place) {
    return Math.floor((Math.abs(num)/Math.pow(10,place))%10)
}

function digitCount(num) {
    // return num.toString().length;
    if(num === 0) return 1;
    return Math.floor(Math.log10(Math.abs(num))) + 1;
}

function mostDigits(arr) {
    var mostdig = 0;
    for (let index = 0; index < arr.length; index++) {
        mostdig = Math.max(mostdig,digitCount(arr[index]));        
    }
    return mostdig;
}

//console.log(getDigit(12345,4))
console.log(digitCount(12345));