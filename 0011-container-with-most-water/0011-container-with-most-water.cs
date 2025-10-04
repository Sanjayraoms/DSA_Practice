public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int l = 0, r = height.Length - 1;
        while(l < r){
            var currArea = (r-l) * Math.Min(height[l], height[r]);
            maxArea = Math.Max(maxArea,currArea);
            if(height[r] > height[l])
                l++;
            else
                r--;
        } 
        return maxArea;
    }
}