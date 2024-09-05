function bubbleSort(arr) {
    let n = arr.length - 1;
    let noswaps = true;
    while (n > 0) {
        noswaps = true;
        for (let index = 0; index <= n-1; index++) {
            console.log(arr,arr[index],arr[index+1])
            if (arr[index] > arr[index+1]) {
                let temp = arr[index]
                arr[index] = arr[index+1];
                arr[index+1] = temp;
                noswaps = false;
            }            
        }
        if(noswaps) break;
        n--;
    }
    return arr;
}

console.log(bubbleSort([5,7,2,6,3,1]));
//console.log(bubbleSort([1,2,5,4,6]))
