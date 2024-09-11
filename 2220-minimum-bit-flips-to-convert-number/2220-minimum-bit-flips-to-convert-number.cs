public class Solution {
    public int MinBitFlips(int start, int goal) {
        var res = start ^ goal;
        return Convert.ToString(res,2).Count(x => x =='1');
    }
}