public class Solution {
    public bool CheckPowersOfThree(int n) {
        while(n > 1){
            var rem = n % 3;
            if(rem == 2)
                return false;
            n /= 3;
        }
        return true;
    }
}