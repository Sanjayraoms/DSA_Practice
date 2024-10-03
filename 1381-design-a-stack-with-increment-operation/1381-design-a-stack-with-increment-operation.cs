public class CustomStack {
    private int _indx;
    int[] stack;
    int poppedVal;
    public CustomStack(int maxSize) {
        _indx = 0;
        stack = new int[maxSize];
    }
    
    public void Push(int x) {
        if(_indx < stack.Length){
            if(_indx < 0)
                _indx = 0;
            stack[_indx] = x;
            _indx++;
        }
    }
    
    public int Pop() {
        if(_indx > 0){
            poppedVal = stack[_indx - 1];
            _indx--;
            return poppedVal;
        }
        return -1;
    }
    
    public void Increment(int k, int val) {
        if(k>stack.Length)
            k = stack.Length;
        for(int i=0;i<k;i++ ){
            stack[i] = stack[i]+val;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */