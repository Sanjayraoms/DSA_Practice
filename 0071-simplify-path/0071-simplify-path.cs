public class Solution {
    public string SimplifyPath(string path) {
        var st = new Stack<string>();
        var pathParts = path.Split('/');
        
        foreach(var part in pathParts){
            if(part == ".."){
                if(st.Count > 0)
                    st.Pop();
            }else if(part != "" && part != ".")
                st.Push(part);
        }

        var res = new StringBuilder();
        while(st.Count > 0){
            res.Insert(0,$"/{st.Pop()}");
        }
        return res.Length==0 ? "/" : res.ToString();
    }
}