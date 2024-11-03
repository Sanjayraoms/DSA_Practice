public class Solution {
    public bool RotateString(string s, string goal) {
        if(s.Length != goal.Length)
            return false;
        string res = s + s;
        return res.Contains(goal);
    }
}