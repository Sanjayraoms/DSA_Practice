public class Solution {
    public bool LemonadeChange(int[] bills) {
        int fives = 0;
        int tens = 0;
        foreach(int bill in bills){
            switch(bill){
                case 5 :
                   fives++;
                   break;
                case 10 :
                   if(fives > 0){
                    tens++;
                    fives--;
                   }
                   else
                     return false;
                   break;
                case 20 :
                   if(tens > 0 && fives > 0){
                    tens--;
                    fives--;
                   }else if(fives > 2)
                      fives -= 3;
                    else
                      return false;
                   break;
            }
        }
        return true;
    }
}