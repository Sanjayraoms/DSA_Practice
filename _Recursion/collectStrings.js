// Write a function called collectStrings which accepts an object and returns 
// an array of all the values in the object that have a typeof string

const obj = {
    stuff: "foo",
    data: {
        val: {
            thing: {
                info: "bar",
                moreInfo: {
                    evenMoreInfo: {
                        weMadeIt: "baz"
                    }
                }
            }
        }
    }
}

console.log(collectStrings(obj)) // ["foo", "bar", "baz"])

function collectStrings(obj1) {
    var arrStr = [];
    for (let key in obj1) {
        let val = obj1[key];
        if(typeof val === "string") {
            arrStr.push(val)
        }
        else if(typeof val === "object") {
            arrStr = arrStr.concat(collectStrings(val))
        }       
    }
return arrStr;
}