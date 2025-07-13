public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        st.Push(s[0]);
        for(int i = 1; i<s.Length; i++){
            switch(s[i]){
                case ')':
                    if(st.Count > 0 && st.Peek() == '(')
                        st.Pop();
                    else
                        st.Push(s[i]);
                    break;
                case '}':
                    if(st.Count > 0 && st.Peek() == '{')
                        st.Pop();
                    else
                        st.Push(s[i]);
                    break;
                case ']':
                    if(st.Count > 0 && st.Peek() == '[')
                        st.Pop();
                    else
                        st.Push(s[i]);
                    break;
                default:
                    st.Push(s[i]);
                    break;
            }
        }
        return st.Count == 0;
    }
}