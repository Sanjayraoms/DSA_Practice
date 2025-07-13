public class MinStack {
    Stack<(int val,int minVal)> minStack;
    int currMin; 
    public MinStack() {
        minStack = new();
        currMin = int.MaxValue;
    }
    
    public void Push(int val) {
        currMin = Math.Min(currMin,val);
        minStack.Push((val,currMin));
    }
    
    public void Pop() {
        minStack.Pop();
        if(minStack.Count > 0){
            var curr = minStack.Peek();
            currMin = curr.minVal;   
        }else
            currMin = int.MaxValue;
    }
    
    public int Top() {
        var top = minStack.Peek();
        return top.val;
    }
    
    public int GetMin() {
        var min = minStack.Peek();
        return min.minVal;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */