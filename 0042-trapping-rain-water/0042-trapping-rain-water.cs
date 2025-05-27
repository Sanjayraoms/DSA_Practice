public class Solution {
    public int Trap(int[] height) {
        int l = 0; 
        int r = height.Length - 1;
        int lMax = height[l];
        int rMax = height[r];
        int res = 0;

        while(l < r){
            if(lMax < rMax){
                l++;
                lMax = Math.Max(lMax,height[l]);
                res += lMax - height[l];
            }else{
                r--;
                rMax = Math.Max(rMax, height[r]);
                res += rMax - height[r];
            }
        }
        return res;
    }
}