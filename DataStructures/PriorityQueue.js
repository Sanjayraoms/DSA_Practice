class Node{
    constructor(val,priority){
        this.val = val;
        this.priority = priority;
    }
}

class minBinaryHeap{
    constructor(){
        this.values = [];
    }
    insert(val,priority){
        var newNode = new Node(val,priority);
        this.values.push(newNode);
        this.bubbleUp();
        return this.values;
    }
    bubbleUp(){
        var currentPosition = this.values.length - 1;
        while (currentPosition > 0) {
            let parentPosition = Math.floor((currentPosition - 1)/2);
            let parent = this.values[parentPosition];
            let current = this.values[currentPosition];
            if (parent.priority > current.priority) {
                this.values[parentPosition] = current;
                this.values[currentPosition] = parent;
                currentPosition = parentPosition;
            }
            if (currentPosition !== parentPosition) break;
        }
    }
    getHighestPriority(len = this.values.length){
        let temp = this.values[0];
        this.values[0] = this.values[len - 1]
        this.values[len - 1] = temp;
        let highestPriority = this.values.pop();
        this.sinkDown();
        return highestPriority;
    }
    sinkDown(){
        const element = this.values[0];
        const len = this.values.length;
        var parentIndex =  0;
        while (true) {
            let leftChildIndex = 2 * parentIndex + 1;
            let rightChildIndex = 2 * parentIndex + 2;
            let swap = null;
            if(leftChildIndex < len){
                let leftChild = this.values[leftChildIndex];
                if(leftChild.priority < element.priority)
                   swap = leftChildIndex;
            }
            if (rightChildIndex < len) {
                let rightChild =  this.values[rightChildIndex];
                if((rightChild.priority < element.priority && swap == null) ||
                   (rightChild.priority < element.priority && rightChild.priority < this.values[swap].priority))
                   swap = rightChildIndex;
            }
            if(swap == null) break;
            this.values[parentIndex] = this.values[swap];
            this.values[swap] = element;
            parentIndex = swap;
        }
    }
}

var minHeap = new minBinaryHeap();
minHeap.insert("Stomach Upset",5);
minHeap.insert("Gun Shot",0);
minHeap.insert("Headache",4);
minHeap.insert("Concussion",3);
minHeap.insert("Swine Flu",1);
minHeap.insert("Dengue",2);
console.log();