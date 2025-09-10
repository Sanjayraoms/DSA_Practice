public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        var res = new int[2];
        for(int i = 1; i <= n; i++){
            if(noZeros(i) && noZeros(n-i)){
                res[0] = i;
                res[1] = n-i;
                break;
            }
        }
        
        return res;
    }

    private bool noZeros(int num){
        while(num > 0){
            var curr = num % 10;
            if(curr == 0)
                return false;
            num = num/10;
        }
        return true;
    }
}