function merge(arr1,arr2) {
    let mergedarr = [];
    let i = 0;
    let j = 0;
    while (i < arr1.length && j < arr2.length) { //My solution had or condition
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

function mergeSort(arr) {
    if(arr.length === 1) return arr;
    let mid = Math.floor(arr.length/2);
    return merge(mergeSort(arr.slice(0,mid)),mergeSort(arr.slice(mid,arr.length)));
}

//console.log(merge([1,10,15],[2,14,99,100]))
console.log(mergeSort([4,1,7,55,22,9,8]))