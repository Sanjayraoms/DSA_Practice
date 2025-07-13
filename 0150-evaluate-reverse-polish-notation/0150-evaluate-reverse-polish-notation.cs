public class Solution {
    public int EvalRPN(string[] tokens) {
        var st = new Stack<int>();
        foreach(var c in tokens){
            int num;
            var success = int.TryParse(c,out num);
            if(success){
                st.Push(num);
            }else{
                var val2 = st.Pop();
                var val1 = st.Pop();
                switch(c){
                    case "/":
                       num = val1/val2;
                       st.Push(num);
                       break;
                    case "-":
                        num = val1-val2;
                        st.Push(num);
                        break;
                    case "*":
                        num = val1*val2;
                        st.Push(num);
                        break;
                    case "+":
                        num = val1+val2;
                        st.Push(num);
                        break;
                    default:
                        break;
                }
            }
        }
        return st.Pop();
    }
}