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

function radixSort(arr) {
    let mostdig = mostDigits(arr);
    for (let index = 0; index < mostdig; index++) {
        let digitBuckets = Array.from({length: 10},() => []);
        for(let i=0;i<arr.length;i++){
            digitBuckets[getDigit(arr[i],index)].push(arr[i]);
        }
        arr = [].concat(...digitBuckets);
    }
    return arr;
}

console.log(radixSort([45,259,698,365,2589,12,37]));