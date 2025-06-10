public class MyQueue {

    Stack<int> st = null;
    Stack<int> temp = null;
    public MyQueue() {
        st = new Stack<int>();
        temp = new Stack<int>();
    }
    
    public void Push(int x) {
        while(st.Count > 0){
            temp.Push(st.Pop());
        }
        st.Push(x);
        while(temp.Count > 0){
            st.Push(temp.Pop());
        }
    }
    
    public int Pop() {
        return st.Pop();
    }
    
    public int Peek() {
        return st.Peek();
    }
    
    public bool Empty() {
        return st.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */