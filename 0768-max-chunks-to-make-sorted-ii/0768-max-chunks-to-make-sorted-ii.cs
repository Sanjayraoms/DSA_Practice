public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        Stack<int> st = new Stack<int>();
        st.Push(arr[0]);
        for(int i = 1; i < arr.Length; i++){
            if(arr[i] >= st.Peek()){
                st.Push(arr[i]);
            }else{
                var currMax = st.Peek();
                while(st.Count > 0 && arr[i] < st.Peek()){
                    st.Pop();
                }
                st.Push(currMax);
            }
        }
        return st.Count;
    }
}