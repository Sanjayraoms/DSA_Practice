public class Solution {
    public bool IsHappy(int n) {
        if(n < 10){
            if(n ==1 || n == 7)
                return true;
            else
                return false;
        }
        int sum = 0;
        while( n > 0){
            var digit = n % 10;
            sum += digit * digit;
            n = n/10;
        }
        return IsHappy(sum);
    }
}