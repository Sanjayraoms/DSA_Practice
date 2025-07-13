public class LRUCache {
    int _capacity = 0; 
    DblLinkedList linkdList = null;
    Dictionary<int,Node> map = null;
    public LRUCache(int capacity) {
        _capacity = capacity;
        linkdList = new DblLinkedList();
        map = new Dictionary<int,Node>();
    }
    
    public int Get(int key) {
        if(map.ContainsKey(key)){
            var currNode = map[key];
            linkdList.removeNode(currNode);
            currNode = linkdList.pushrecentlyused(currNode.val, currNode.key);
            map[key] = currNode;
            return currNode.val;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(map.ContainsKey(key)){
            var currNode = map[key];
            linkdList.removeNode(currNode);
            map.Remove(key);
        }
        if(map.Count == _capacity){
            var k = linkdList.removeNonUsed();
            map.Remove(k);
            var node = linkdList.pushrecentlyused(value,key);
            map[key] = node;
        }else{
            var node = linkdList.pushrecentlyused(value,key);
            map[key] = node;
        }
    }
}

public class Node{
    public Node prev;
    public Node next;
    public int val;
    public int key;
    public Node(int val, int key){
        this.val = val;
        this.key = key;
        prev = null;
        next = null;
    }
}
public class DblLinkedList
{
    Node head;
    Node tail;
    public DblLinkedList(){
        head = new Node(-1,-1);
        tail = new Node(-1, -1);
        head.prev = null;
        head.next = tail;
        tail.prev = head;
        tail.next = null;
    }

    public Node pushrecentlyused(int val, int key){
        var node = new Node(val,key);
        var currnext = head.next;
        head.next = node;
        node.prev = head;
        node.next = currnext;
        currnext.prev = node;

        return node;
    }

    public int removeNonUsed(){
        var newOld = tail.prev.prev;
        var old = tail.prev;
        old.prev = null;
        old.next = null;

        tail.prev = newOld;
        newOld.next = tail;

        return old.key;
    }
    public void removeNode(Node currNode){
        var prev = currNode.prev;
        var next = currNode.next;

        currNode.next = null;
        currNode.prev = null;

        prev.next = next;
        next.prev = prev;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */