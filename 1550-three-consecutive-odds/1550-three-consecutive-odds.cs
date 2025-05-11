public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        if (arr.Length < 3)
           return false;
        int conseOdds = 0;
        foreach(int num in arr){
            if(num%2 == 1){
                conseOdds++;
            }else{
                conseOdds = 0;
            }
            if (conseOdds == 3)
               return true;
        }
        return false;
    }
}