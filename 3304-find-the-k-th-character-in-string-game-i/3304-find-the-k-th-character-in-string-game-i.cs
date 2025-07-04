public class Solution {
    public char KthCharacter(int k) {
        StringBuilder sb = new("a");

        while(sb.Length < k){
            StringBuilder curr = new();
            foreach(char c in sb.ToString()){
                if(c == 'z'){
                    curr.Append('a');
                }else{
                    var codeVal = (int)c;
                    codeVal++;
                    curr.Append((char)codeVal);
                }
            }
            sb.Append(curr);
        }
        var res = sb.ToString();
        return res[k-1];
    }
}