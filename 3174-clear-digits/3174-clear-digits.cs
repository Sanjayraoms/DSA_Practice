public class Solution {
    public string ClearDigits(string s) {
        var st = new Stack<char>();
        var res = new StringBuilder();

        int num = 0;
        for(int i = 0; i < s.Length; i++){
            if(Char.IsNumber(s[i])){
                if(st.Count > 0)
                    st.Pop();
            }else
                st.Push(s[i]);
        }
        var arr = st.ToArray();
        for(int i = arr.Length - 1; i >= 0; i--){
            res.Append(arr[i]);
        }
        return res.ToString();
    }
}