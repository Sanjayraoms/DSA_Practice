public class Solution {
    public bool HasMatch(string s, string p) {
        string[] str = p.Split('*');
        int indx = 0;
        foreach(string sub in str){
            if(String.IsNullOrEmpty(sub))
                continue;
            indx = s.IndexOf(sub,indx);
            if(indx < 0)
                return false;
            indx = indx + sub.Length;
        }
        return true;
    }
}