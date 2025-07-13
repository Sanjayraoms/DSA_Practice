public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        int content = 0;
        Array.Sort(g);
        Array.Sort(s);
        int gr = 0, ck = 0;

        while(gr < g.Length && ck < s.Length){
            if(g[gr] <= s[ck]){
                content++;
                gr++;
                ck++;
            }else
                ck++;
        }
        return content;
    }
}