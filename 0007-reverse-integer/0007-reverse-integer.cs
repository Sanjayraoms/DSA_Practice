public class Solution {
    public int Reverse(int x) {
        var res = 0;
        var p = int.MaxValue / 10;
        int n = int.MinValue / 10;
        while(x != 0){
            if(res > p || res < n )
                return 0;
            res = (res * 10) + (x % 10);
            x = x/10;
        }
        return res;
    }
}