public class Solution {
    public int GetLucky(string s, int k) {
        StringBuilder sb = new StringBuilder();
        int res = 0;
        foreach(char c in s){
            sb.Append((c - 'a')+1);
        }
        while(k > 0){
            for(int i =0; i< sb.Length; i++){
                res += int.Parse(sb[i].ToString());
            }
            sb.Clear();
            sb.Append(res);
            res = 0;
            k--;
        }
        return int.Parse(sb.ToString());
    }
}