public class Solution {
    public int CalPoints(string[] operations) {
        var st = new Stack<int>();
        int score = 0;
        foreach(var str in operations){
            switch(str){
                case "D":
                    var curr = st.Peek();
                    st.Push(curr*2);
                    break;
                case "C":
                    st.Pop();
                    break;
                case "+":
                    var curr1 = st.Pop();
                    var curr2 = st.Pop();
                    st.Push(curr2);
                    st.Push(curr1);
                    st.Push(curr1+curr2);
                    break;
                default:
                    st.Push(Int32.Parse(str));
                    break;
            }
        }
        while(st.Count > 0){
            score += st.Pop();
        }
        return score;
    }
}