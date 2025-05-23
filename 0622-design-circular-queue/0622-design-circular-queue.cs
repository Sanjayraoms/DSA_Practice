public class Node{
    public Node next;
    public Node prev;
    public int val;
    public Node(int val){
        next = null;
        prev = null;
        this.val = val;
    }
}

public class MyCircularQueue {
    int len = 0;
    int total = 0;
    Node Head;
    Node Tail;
    public MyCircularQueue(int k) {
        total = k;
        Head = null;
        Tail = null;
    }
    
    public bool EnQueue(int value) {
        var newNode = new Node(value);
        if(len == 0){
            Head = newNode;
            Tail = newNode;
            len++;
            return true;
        }else if(len < total){
            Tail.next = newNode;
            newNode.prev = Tail;
            Tail = newNode;
            len++;
            return true;
        }
        return false;

    }
    
    public bool DeQueue() {
        if(len > 0){
            var currHead = Head;
            if(Head == Tail){
                Head = null;
                Tail = null;
            }else{
                Head = currHead.next;
                currHead.next = null;
                Head.prev = null;
            }
            len--;
            return true;
        }
        return false;
    }
    
    public int Front() {
        if(len > 0)
            return Head.val;
        return -1;
    }
    
    public int Rear() {
        if(len > 0)
            return Tail.val;
        return -1;
    }
    
    public bool IsEmpty() {
        return len == 0;
    }
    
    public bool IsFull() {
        return len == total;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */