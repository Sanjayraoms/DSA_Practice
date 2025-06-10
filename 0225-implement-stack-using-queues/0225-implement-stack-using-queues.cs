public class MyStack {
    Queue<int> q1 = null;
    Queue<int> q2 = null;
    public MyStack() {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }
    
    public void Push(int x) {
        if(q1.Count > q2.Count)
            q1.Enqueue(x);
        else
            q2.Enqueue(x);
    }
    
    public int Pop() {
        if(q1.Count > q2.Count){
            while(q1.Count > 1){
                q2.Enqueue(q1.Dequeue());
            }
            return q1.Dequeue();
        }else if(q2.Count > 0){
            while(q2.Count > 1){
                q1.Enqueue(q2.Dequeue());
            }
            return q2.Dequeue();
        }
        return 0;
    }
    
    public int Top() {
        var top = 0;
        if(q1.Count > q2.Count){
            while(q1.Count > 1){
                q2.Enqueue(q1.Dequeue());
            }
            top = q1.Dequeue();
            q2.Enqueue(top); 
        }else if(q2.Count > 0){
            while(q2.Count > 1){
                q1.Enqueue(q2.Dequeue());
            }
            top = q2.Dequeue();
            q1.Enqueue(top); 
        }
        return top;
    }
    
    public bool Empty() {
        return q1.Count == 0 && q2.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */