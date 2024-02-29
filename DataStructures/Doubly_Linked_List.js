class Node {
    constructor(val){
        this.val = val;
        this.next = null;
        this.prev = null;
    }
}

class DoublyLinkedList{
    constructor(){
        this.head = null;
        this.tail = null;
        this.length = 0;
    }
    push(val){
        let newNode = new Node(val);
        if (this.length === 0) {
            this.head =newNode;
            this.tail = newNode;
        }else{
            this.tail.next = newNode;
            newNode.prev = this.tail;
            this.tail = newNode;
        }
        this.length++;
        return this;
    }
    pop(){
        if(this.length === 0) return undefined;
        let currentTail = this.tail;
        if (this.head === this.tail) {
            this.head = null;
            this.tail = null;
        }else{
            this.tail = currentTail.prev;
            currentTail.prev = null;
            this.tail.next = null;
        }
        this.length--;
        return currentTail;
    }
    shift(val){
        var newHead = new Node(val);
        if (this.length === 0) {
            this.head = newHead;
            this.tail = newHead;
        }else{
            newHead.next = this.head;
            this.head.prev = newHead;
            this.head = newHead;
        }
        this.length++;
        return this;
    }
    unshift(){
        if(this.length === 0) return undefined;
        var unshifthead = this.head;
        if(this.length === 1){
            this.head = null;
            this.tail = null;
        }else{
            this.head = unshifthead.next;
            this.head.prev = null;
        }        
        this.length--;
        return unshifthead;
    }
}

var list = new DoublyLinkedList();
list.push("Hey");
list.push("How");
list.push("are");
// console.log(list.pop())
console.log()