class Node{
    constructor(val){
        this.val = val;
        this.next = null;
    }
}

class SinglyLinkedList{
    constructor(){
        this.head = null;
        this.tail = null;
        this.length = 0;
    }
    push(val){
        let newNode = new Node(val);
        if (this.head === null) {
            this.head = newNode;
            this.tail = this.head;
        }else{
            this.tail.next = newNode;
            this.tail = newNode;
        }
        this.length++;
        return this;
    }
    pop(){
        if(this.length === 0) return undefined;
        //My Implementation
        // if (this.head === this.tail) {
        //     let poppedVal = this.head.val;
        //     this.head = null;
        //     this.tail = null;
        //     this.length--;
        //     return poppedVal;
        // }
        // let current = this.head;
        // while (current) {
        //     if (current.next === this.tail) {
        //         let poppedVal = this.tail.val;
        //         current.next = null;
        //         this.tail = current;
        //         this.length--;
        //         return poppedVal;
        //     }
        //     current = current.next;
        // }
        //Better Implementation
        if(this.length === 0) return undefined;
        let newTail = this.head;
        let current = newTail;
        while(current.next){
            newTail = current;
            current = current.next;
        }
        newTail.next = null;
        this.tail = newTail;
        this.length--;
        if (this.length === 0) {
            this.head = null;
            this.tail = null;
        }
        return current;
    }
    shift(){
        if(this.length === 0) return undefined;
        let current = this.head;
        this.head = this.head.next;
        this.length--;
        if (this.length === 0) {
            this.head = null;
            this.tail = null;
        }
        return current;
    }
    unshift(val){
        let newNode = new Node(val);
        if(this.length === 0){
            this.head = newNode;
            this.tail = newNode;
        }else{
            newNode.next = this.head;
            this.head = newNode
        }
        this.length++;
        return this;
    }
    get(index){
        if (index < 0 || index > this.length) {
            return null;
        }
        let current = this.head
        while (index > 0) {
            current = current.next;
            index--;
        }
        return current;
    }
    set(index,newVal){
        let foundNode = this.get(index);
        if (foundNode) {
            foundNode.val = newVal;
            console.log(foundNode);
            return true;
        }
        return false;
    }
    insert(index,val){
        if(index > this.length && index < 0) return false;
        if(index === this.length) return !!this.push(val);
        if(index === 0) return !!this.unshift(val);

        let newNode = new Node(val);
        let prevNode = this.get(index-1);
        newNode.next = prevNode.next;
        prevNode.next = newNode;
        this.length++;
        return true;
    }
    remove(index){
        if(index > this.length && index < 0) return false;
        if(index=== this.length-1) return this.pop();
        if(index === 0) return this.shift();

        let prevNode = this.get(index-1);
        let removeNode = prevNode.next;
        prevNode.next = removeNode.next;
        this.length--;
        return removeNode;
    }
    reverse(){
        //My solution
        // let temp = this.head;
        // this.head = this.tail;
        // this.tail = temp;
        // let prev = this.tail;
        // let current = prev.next;
        // let next = current.next;
        // this.tail.next = null;
        // while(true){
        //     current.next = prev;
        //     prev = current;
        //     if(prev === this.head) break;
        //     current = next;
        //     next = current.next;
        // }
        //Better solution
        var node = this.head;
        this.head = this.tail;
        this.tail = node;
        var next;
        var prev = null;
        for (let index = 0; index < this.length; index++) {
            next = node.next;
            node.next = prev;
            prev = node;
            node = next;
        }
        return this;
    }
}
var list= new SinglyLinkedList();
list.push("Hello");
list.push("Keerthi");
list.push("How");
list.push("are");
list.push("you?");
// console.log(list.get(0));
// console.log(list.get(2));
// console.log(list.get(4));
// console.log(list.insert(0,"FIRST"));
// console.log(list.remove(4));
console.log(list.reverse());
// console.log(list.unshift("Hi,"));
// console.log(list.shift());
// console.log(list.shift());
// console.log(list.shift());
// console.log(list.shift());
// console.log(list.shift());
// console.log(list.shift());
console.log()