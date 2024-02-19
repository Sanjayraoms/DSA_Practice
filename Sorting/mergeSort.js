function merge(arr1,arr2) {
    let mergedarr = [];
    let i = 0;
    let j = 0;
    while (i < arr1.length && j < arr2.length) { //My solution had or
        // if (i===arr1.length && j < arr2.length){
        //     mergedarr.push(arr2[j]);
        //     j++;
        //     continue;
        // }
        // if (j===arr2.length && i < arr1.length){
        //     mergedarr.push(arr1[i]);
        //     i++;
        //     continue;
        // }
        if (arr1[i] < arr2[j]) {
            mergedarr.push(arr1[i]);
            i++;
        }else{
            mergedarr.push(arr2[j]);
            j++;
        }
    }
    while (i<arr1.length) {
        mergedarr.push(arr1[i]);
        i++;
    }
    while (j<arr2.length) {
        mergedarr.push(arr2[j]);
        j++;
    }
    return mergedarr;
}

//console.log(merge([1,10,15],[2,14,99,100]))
console.log(merge([],[2,14,99,100]))