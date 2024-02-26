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
console.log(list.set(6,"Where"));
console.log(list)
// console.log(list.unshift("Hi,"));
// console.log(list.shift());
// console.log(list.shift());
// console.log(list.shift());
// console.log(list.shift());
// console.log(list.shift());
// console.log(list.shift());
console.log()