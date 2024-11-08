public class Solution {
    public int LargestCombination(int[] candidates) {
        int[] count = new int[24];
        for(int i = 0; i < count.Length; i++){
            foreach(int num in candidates){
                if((num & (1<<i)) != 0){
                    count[i]++;
                }
            }
        }
        int max = 0;
        foreach(int c in count){
            if(c > max) max = c;
        }
        return max;
    }
}