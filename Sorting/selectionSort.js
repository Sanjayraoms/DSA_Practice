function selectionSort(arr) {
    // let minIndex = 0;
    // let iterate = 0;
    // while (iterate < arr.length) {
    //     for (let index = iterate; index < arr.length; index++) {
    //         if (arr[minIndex]>arr[index] ) {
    //             minIndex = index;
    //         }            
    //     }
    //     let temp = arr[minIndex];
    //     arr[minIndex] = arr[iterate];
    //     arr[iterate] = temp;
    //     iterate++;
    // }
    // return arr;
    for (let i = 0; i < arr.length; i++) {
        let lowest = i;
        for (let j = i+1 ; j < arr.length; j++) {
            if (arr[j] < arr[lowest]) {
                lowest = j;
            }
        }
        if (i !== lowest) {
            let temp = arr[i];
            arr[i] = arr[lowest];
            arr[lowest] = temp;
        }
    }
    return arr;
}

console.log(selectionSort([5,7,2,6,3,1]))