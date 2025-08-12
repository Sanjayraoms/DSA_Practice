public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false;
        int rev = 0;
        int temp = x;
        while(temp > 0){
            var rem = temp % 10;
            rev = rev * 10 + rem;
            temp = temp / 10;
        }
        return x == rev;
    }
}