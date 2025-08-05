public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        int cnt = 0;
        for(int i = 0; i < fruits.Length; i++){
            for(int j = 0; j < baskets.Length; j++){
                if(fruits[i] <= baskets[j]){
                    cnt++;
                    baskets[j] = 0;
                    break;
                }
            }
        }
        return fruits.Length - cnt;
    }
}