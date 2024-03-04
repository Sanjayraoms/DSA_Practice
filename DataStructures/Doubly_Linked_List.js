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
    unshift(val){
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
    shift(){
        if(this.length === 0) return undefined;
        var shifthead = this.head;
        if(this.length === 1){
            this.head = null;
            this.tail = null;
        }else{
            this.head = shifthead.next;
            this.head.prev = null;
            shifthead.next = null;
        }        
        this.length--;
        return shifthead;
    }
    get(index){
        if(index < 0 || index >= this.length) return undefined;
        if(index === 0) return this.head;
        var current,count;
        if (index >= this.length/2) {
            current = this.tail;
            count = this.length - 1;
            while(count !== index){
                current = current.prev;
                count--;
            }
        }else{
            count = 0;
            current = this.head;
            while(index > 0){
                current = current.next;
                count++;
            }
        }
        return current;
    }
    set(index,val){
        var updateNode = this.get(index);
        if (updateNode !== undefined) {
            updateNode.val = val;
            return true;
        }
        return false;
    }
    insert(index,val){
        if(index < 0 || index > this.length) return false;
        if(index == 0) 
            this.unshift(val);
        else if(index == this.length)
            this.push(val);
        else{
            var newNode = new Node(val);
            var prevNode = this.get(index-1);
            newNode.next = prevNode.next;
            newNode.prev = prevNode;
            prevNode.next = newNode;
            newNode.next.prev = newNode;
            this.length++;
        }
        return list;
    }
}

var list = new DoublyLinkedList();
list.push("Hey");
list.push("How");
list.push("are");
list.push("you");
list.push("?");
// console.log(list.pop())
console.log();
//console.log(list.get(3))
