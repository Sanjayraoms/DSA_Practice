class BinaryHeap{
    constructor(){
        this.values = [100,19,36,17,12,25,5,9,15];
    }
    insert(val){
        this.values.push(val);
        if (this.values.length > 1) {
            this.bubbleUp();
        }
        return this.values;
    }
    bubbleUp(){
        var currentIndex = this.values.length - 1;
        while (currentIndex > 0) {
            parentIndex = Math.floor((currentIndex-1)/2);
            if (this.values[currentIndex] > this.values[parentIndex]) {
                let temp = this.values[currentIndex];
                this.values[currentIndex] = this.values[parentIndex];
                this.values[parentIndex] = temp;
                currentIndex = parentIndex;
            }else{
                return;
            }
        }
    }
    extractMax(){
        let temp = this.values[0];
        this.values[0] = this.values[this.values.length - 1];
        this.values[this.values.length - 1] = temp;
        var maxVal = this.values.pop();
        this.sinkDown();
        return maxVal;
    }
    sinkDown(){
        var parentIndex = 0;
        const heapLength = this.values.length;
        const element = this.values[0];
//My solution
        // while (parentIndex < this.values.length-1) {
        //     let leftChildIndex = 2*parentIndex+1;
        //     let rightChildIndex = 2*parentIndex+2;
        //     let oldParentIndex = parentIndex;
        //     if (leftChildIndex < heapLength) {
        //         if (rightChildIndex < heapLength) {
        //             if (this.values[leftChildIndex] > this.values[rightChildIndex]) {
        //                 if (this.values[leftChildIndex] > this.values[parentIndex]) {
        //                     let temp = this.values[leftChildIndex];
        //                     this.values[leftChildIndex] = this.values[parentIndex];
        //                     this.values[parentIndex] = temp;
        //                     parentIndex = leftChildIndex;
        //                 }
        //             }else{
        //                 if (this.values[rightChildIndex] > this.values[parentIndex]) {
        //                     let temp = this.values[rightChildIndex];
        //                     this.values[rightChildIndex] = this.values[parentIndex];
        //                     this.values[parentIndex] = temp;
        //                     parentIndex = rightChildIndex;
        //                 }
        //             }
        //         }else{
        //             if (this.values[leftChildIndex] > this.values[parentIndex]) {
        //                 let temp = this.values[leftChildIndex];
        //                 this.values[leftChildIndex] = this.values[parentIndex];
        //                 this.values[parentIndex] = temp;
        //                 parentIndex = leftChildIndex;
        //             }
        //         }
        //     }
        //     if (oldParentIndex === parentIndex) break;
        // }
//Better solution
       while (true) {
         let leftChildIndex = 2 * parentIndex + 1;
         let rightChildIndex = 2 * parentIndex + 2;
         let swap = null;
         if (leftChildIndex < heapLength) {
            let leftChild = this.values[leftChildIndex];
            if (leftChild > element) {
                swap = leftChildIndex;
            }
         }
         if (rightChildIndex < heapLength) {
            let rightChild = this.values[rightChildIndex];
            if ((rightChild > element && swap === null)||
                (rightChild > element && rightChild > this.values[swap])) {
                swap = rightChildIndex;
            }
         }
         if (swap === null) break;
         this.values[parentIndex] = this.values[swap];
         this.values[swap] = element;
         parentIndex = swap;
       }
    }
}

var heap = new BinaryHeap();
console.log()