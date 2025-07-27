public class Solution {
    public string DecodeString(string s) {
        var currres = new StringBuilder("");
        var st = new Stack<string>();
        foreach(char c in s){
            if(c != ']')
                st.Push(c.ToString());
            else{
                //Get the characters inside the brackets
                var currSb = new StringBuilder("");
                while(st.Count > 0 && st.Peek() != "["){
                    currSb.Insert(0,st.Pop());
                }

                //Pop the opening bracket
                if(st.Peek() == "[")
                    st.Pop();
                
                //Get the digits outside the bracket
                var currNumSb = new StringBuilder("");
                while(st.Count > 0 && char.IsNumber(st.Peek()[0])){
                    currNumSb.Insert(0,st.Pop());
                }

                //Multiply the string with digit
                int currNum = int.Parse(currNumSb.ToString());
                var currStr = currSb.ToString();
                while(currNum-- > 0){
                    currres.Insert(0,currStr);
                }
                st.Push(currres.ToString());
                currres.Clear();
            }
        }
        while(st.Count > 0){
            currres.Insert(0,st.Pop());
        }
        return currres.ToString();
    }
}