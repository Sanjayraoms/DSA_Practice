// Write a function called stringifyNumbers which takes in an object and 
// finds all of the values which are numbers and converts them to strings.
// Recursion would be a great way to solve this!


let obj = {
    num: 1,
    test: [],
    data: {
        val: 4,
        info: {
            isRight: true,
            random: 66
        }
    }
}

console.log(stringifyNumbers(obj))

/*
{
    num: "1",
    test: [],
    data: {
        val: "4",
        info: {
            isRight: true,
            random: "66"
        }
    }
}
*/
function stringifyNumbers(obj1){
    var newObj = {}
    if (Object.keys(obj1).length === 0) {
        return obj1;
    }
    for (let key in obj1) {
        let val = obj1[key];
        if (typeof val === 'object') {
            newObj[key] = stringifyNumbers(val);
        }else{
            if(typeof val === 'number'){
                newObj[key] = val.toString();
            }else{
                newObj[key] = val
            }
        }
    }
    return newObj;
}