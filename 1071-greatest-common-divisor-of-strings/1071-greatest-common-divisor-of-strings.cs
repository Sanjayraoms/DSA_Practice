public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if(str1+str2 != str2+str1)
           return "";
        int gcdLength = gcd(str1.Length,str2.Length);
        return str1.Substring(0,gcdLength);
    }
    public int gcd(int x, int y){
        if(x > y){
            if(y == 0)
               return x;
            else
               return gcd(y, x % y);
        }else{
            if(x == 0)
               return y;
            else
               return gcd(x, y % x);
        }
    }
}