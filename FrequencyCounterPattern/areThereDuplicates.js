//Implement a function called, areThereDuplicates which accepts a variable number of arguments, 
//and checks whether there are any duplicates among the arguments passed in
console.log(areThereDuplicates(1, 2, 3)) // false
console.log(areThereDuplicates(1, 2, 2)) // true 
console.log(areThereDuplicates('a', 'b', 'c', 'a')) // true 

function areThereDuplicates() {
    var lookup = {};
    for (let index = 0; index < arguments.length; index++) {
        if(lookup[arguments[index]]){
            return true;
        }
        lookup[arguments[index]] = 1;       
    }
    return false;
}