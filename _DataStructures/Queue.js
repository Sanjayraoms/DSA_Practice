class Node{
    constructor(val){
        this.val = val;
        this.next = null;
    }
}

class Queue{
    constructor(){
        this.first = null;
        this.last = null;
        this.length = 0;
    }
    enqueue(val){
        var newNode = new Node(val);
        if (this.length === 0) {
            this.first = newNode;
            this.last = newNode;
        }else{
            this.last.next = newNode;
            this.last = newNode;
        }
        this.length++;
    }
    dequeue(){
        if(this.length == 0) return null;
        var deqNode = this.first;
        this.first = deqNode.next;
        deqNode.next = null;
        this.length--;
        if (this.length == 0) {
            this.first = null;
            this.last = null;
        }
        return deqNode.val;
    }
}
var q = new Queue();
q.enqueue(10);
q.enqueue(20);
q.enqueue(30);
q.enqueue(40);
q.enqueue(50);
q.enqueue(60);