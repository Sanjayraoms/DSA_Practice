public class MyHashMap {
    Dictionary<int,int> map;
    public MyHashMap() {
        map = new Dictionary<int,int>();
    }
    
    public void Put(int key, int value) {
        map[key] = value;
    }
    
    public int Get(int key) {
        if(map.ContainsKey(key))
            return map[key];
        return -1;
    }
    
    public void Remove(int key) {
        map.Remove(key);
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */