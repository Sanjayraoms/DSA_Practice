function getPivot(arr,start = 0,end = arr.length) {
    const swap = (arr, idx1, idx2) => {
        [arr[idx1], arr[idx2]] = [arr[idx2], arr[idx1]];
      };
    let pivot = arr[start];
    let currentPivot = start;
    for (let index = start+1; index <= end; index++) {
        if (pivot > arr[index] ) {
            currentPivot++;
            swap(arr,currentPivot,index);          
        }
    }
    swap(arr,currentPivot,start);  
    return currentPivot;
}

function quickSort(arr,left = 0, right = arr.length - 1){
    if (left<right) {
        let pivotIndex = getPivot(arr,left,right);
        quickSort(arr,left, pivotIndex - 1);
        quickSort(arr,pivotIndex+1,right);
    }
    return arr;
}

console.log(quickSort([26,23,27,44,17,47,39,42,43]))