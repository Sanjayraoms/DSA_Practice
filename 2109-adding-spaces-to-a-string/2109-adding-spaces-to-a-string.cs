public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        StringBuilder sb = new StringBuilder("");
        int start = 0;
        foreach(int space in spaces){
            var end = space;
            for(int i = start;i < end; i++){
                sb.Append(s[i]);
            }
            sb.Append(" ");
            start = end;
        }
        for(int i = start; i < s.Length;i++){
            sb.Append(s[i]);
        }
        return sb.ToString().TrimEnd();
    }
}