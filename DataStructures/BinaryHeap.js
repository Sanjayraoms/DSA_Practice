class BinaryHeap{
    constructor(){
        this.values = [];
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
        var parentIndex = Math.floor((currentIndex-1)/2);
        while (true) {
            if (this.values[currentIndex] > this.values[parentIndex]) {
                let temp = this.values[currentIndex];
                this.values[currentIndex] = this.values[parentIndex];
                this.values[parentIndex] = temp;
                currentIndex = parentIndex;
                parentIndex = Math.floor((currentIndex-1)/2);
            }else{
                return;
            }
        }
    }
}

var heap = new BinaryHeap();
console.log()