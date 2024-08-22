public class Solution {
    public string RemoveStars(string s) {
        Stack<char> st = new Stack<char>();
        Stack<char> res = new Stack<char>();
        int stars = 0;
        foreach(char c in s){
            st.Push(c);
        }
        while(st.Count > 0){
            if(st.Peek() == '*'){
                stars++;
                st.Pop();
            }
            else{
                if(stars > 0){
                    st.Pop();
                    stars--;
                }
                else
                   res.Push(st.Pop());
            }
              
        }
        if(res.Count > 0){
            return new String(res.ToArray());
        }
        return "";
    }
}