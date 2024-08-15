public class Solution {
    public bool LemonadeChange(int[] bills) {
        int fives = 0;
        int tens = 0;
        foreach(int bill in bills){
            if(bill == 5)
               fives++;
            else if(bill == 10){
                tens++;
                fives--;
            }else{
                if(tens > 0){
                    tens--;
                    fives--;
                }else{
                    fives -= 3;
                }
            }
            if(fives < 0)
               return false;
        }
        return true;
    }
}