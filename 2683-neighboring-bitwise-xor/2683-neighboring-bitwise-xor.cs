public class Solution {
    public bool DoesValidArrayExist(int[] derived) {
        int XOR = 0;
        foreach(int i in derived){
            XOR = XOR ^ i;
        }
        return XOR == 0;
    }
}