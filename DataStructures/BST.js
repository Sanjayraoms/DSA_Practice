class Node{
    constructor(val){
        this.val = val;
        this.left = null;
        this.right = null;
    }
}

class BinarySearchTree{
    constructor(){
        this.root = null;
    }
    insertNode(val){
        var newNode = new Node(val);
        if(!this.root) {
            this.root = newNode;
            return this;
        }
        var currentNode = this.root;
        while (true) {
            if(newNode.val === currentNode.val) return undefined;
            if (newNode.val > currentNode.val) {
                if (!currentNode.right) {
                    currentNode.right = newNode;
                    return this;
                }
                currentNode = currentNode.right;
            }else if(newNode.val < currentNode.val){
                if (!currentNode.left) {
                    currentNode.left = newNode;
                    return this;
                }
                currentNode = currentNode.left;
            }
        }
    }
    find(val){
        if(!this.root) return false;
        var currentNode = this.root;
        var found = false;
        while(currentNode && !found){
            if (val > currentNode.val) {
                currentNode = currentNode.right;
            }else if(val < currentNode.val){
                currentNode = currentNode.left;
            }else{
                return currentNode;
            }
        }
        return found;
    }
}

var bst = new BinarySearchTree();
bst.insertNode(10);
bst.insertNode(15);
bst.insertNode(6);