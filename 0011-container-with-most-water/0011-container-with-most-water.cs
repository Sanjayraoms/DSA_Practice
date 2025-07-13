public class Solution {
    public int MaxArea(int[] height) {
        int i = 0;
        int j = height.Length - 1;

        int res = 0;
        while(i < j){
            var curr = Math.Min(height[i], height[j]);
            res = Math.Max(res,curr*(j-i));
            if(height[j] > height[i])
                i++;
            else
                j--;
        }
        return res;
    }
}