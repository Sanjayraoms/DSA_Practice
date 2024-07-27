public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if(n == 0)
           return true;
        if(flowerbed.Length == 1)
           return (flowerbed[0]==0);
        for(int i = 0; i <= flowerbed.Length; i++){
            if(i == 0){
                if(flowerbed[i+1] == 0 && flowerbed[i] == 0){
                    n--;
                    i++;
                }
            }else if(i == flowerbed.Length - 1){
                if(flowerbed[i-1] == 0 && flowerbed[i] == 0)
                   n--;
            }
            else if(flowerbed[i-1] == 0 &&
                    flowerbed[i] == 0 &&
                    flowerbed[i+1] == 0){
                n--;
                i++;
            }
            if(n == 0)
              return true;
        }
        return false;
    }
}