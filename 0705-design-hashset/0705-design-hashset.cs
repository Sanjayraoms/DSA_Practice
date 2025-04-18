public class MyHashSet {
    int[] set;
    public MyHashSet() {
        set = new int[1000001];
    }
    
    public void Add(int key) {
        if(set[key] == 0)
            set[key] = 1;
    }
    
    public void Remove(int key) {
        set[key] = 0;
    }
    
    public bool Contains(int key) {
        if(set[key] == 1)
            return true;
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */