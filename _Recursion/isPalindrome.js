// Write a recursive function called isPalindrome which returns true if the string passed to it
//  is a palindrome (reads the same forward and backward). Otherwise it returns false.

console.log(isPalindrome('awesome')) // false
console.log(isPalindrome('foobar')) // false
console.log(isPalindrome('tacocat')) // true
console.log(isPalindrome('amanaplanacanalpanama')) // true
console.log(isPalindrome('amanaplanacanalpandemonium')) // false

function isPalindrome(str) {
    let origStr = str;
    function reverse(str){
        if(str.length === 0) return "";
        let rev = str[str.length - 1];
        return rev.concat(reverse(str.substring(0,str.length - 1)));
     }
     let revStr = reverse(str);
     if (origStr === revStr) {
        return true;
     }
     return false;
}