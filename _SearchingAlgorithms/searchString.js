//Write a program to find how many times shorter string is repeated in longer string

console.log(findstringrepeat("wowomgzomg","omg"))
console.log(findstringrepeat("harold said haha in hamburg","ha"))

function findstringrepeat(longrStr,shortrStr) {
    if(longrStr.length < shortrStr.length) return 0;
    let repeat = 0;
    let index = 0;
    while (index < longrStr.length) {
        for (let index2 = 0; index2 < shortrStr.length; index2++) {
            if (longrStr[index] !== shortrStr[index2]) {
                index++;
                break;
            }
            else
               index++;
            
            if(index2 === shortrStr.length -1) repeat += 1;
        }
    }
    return repeat;
}