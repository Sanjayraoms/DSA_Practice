class Node{
    constructor(val){
        this.val = val;
        this.next = null;
    }
}

class Stack{
    constructor(){
        this.First = null;
        this.Last = null;
        this.length = 0;
    }
    push(val){
        var newNode = new Node(val);
        if (this.length === 0) {
            this.First = newNode;
            this.Last = newNode;
        }else{
            newNode.next = this.First;
            this.First = newNode;
        }
        this.length++;
        return this;
    }
    pop(){
        if(this.length == 0) return null;
        var poppedVal = this.First;
        this.First = poppedVal.next;
        poppedVal.next = null;
        this.length--;
        if (this.length === 0) {
            this.First = null;
            this.Last = null;
        }
        return poppedVal.val;
    }
}
var st= new Stack();
st.push("Hi");
console.log();