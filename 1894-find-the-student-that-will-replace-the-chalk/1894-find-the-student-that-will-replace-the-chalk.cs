public class Solution {
    public int ChalkReplacer(int[] chalk, int k) {
        int chalkSum = 0;
        bool skipWhile = false;
        for(int i = 0; i< chalk.Length; i++){
            chalkSum += chalk[i];
            if(chalkSum >= k){
                chalkSum -= chalk[i];
                skipWhile = true;
                break;
            }
        }
        while(k > chalkSum && skipWhile == false){
            if(k - chalkSum >= 0)
               k = k - chalkSum;
            else
               break;
        }
        for(int i = 0; i< chalk.Length;i++){
            if(k >= chalk[i])
               k = k - chalk[i];
            else
               return i;
        }
        return 0;
    }
}