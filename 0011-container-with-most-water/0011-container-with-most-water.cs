public class Solution {
    public int MaxArea(int[] height) {
        int i = 0;
        int j = height.Length - 1;
        int maxStorage = int.MinValue;
        int currentStorage = 0;
        while(i < j){
            currentStorage = Math.Min(height[i],height[j]) * (j - i);
            maxStorage = Math.Max(maxStorage, currentStorage);
            if(height[i] < height[j])
               i++;
            else
               j--;
        }
        return maxStorage;
    }
}