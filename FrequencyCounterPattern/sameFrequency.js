//Write a function called sameFrequency. Given two positive integers, find out if the two numbers have the same frequency of digits.

function sameFrequency(num1,num2) {
    if(num1.length !== num2.length) return false;
    var lookup = {};
    var digit = 0;
    while (num1 !== 0) {
        digit = num1 % 10;
        lookup[digit] = (lookup[digit] || 0) +1;
        num1 = Math.floor(num1/10);
    }
    while (num2 !== 0) {
        digit = num2 % 10;
        if (!lookup[digit]) {
            return false;
        }
        lookup[digit]--;
        num2 = Math.floor(num2/10);
    }
    return true;
}

console.log(sameFrequency(182,281))  // true
console.log(sameFrequency(34,14))  // false
console.log(sameFrequency(3589578, 5879385))  // true
console.log(sameFrequency(22,222))  // false