public class Solution {
    public void Rotate(int[] nums, int k) {
        var n = nums.Length;
        void reverse(int start,int end){
            while(start < end){
                (nums[start], nums[end]) = (nums[end],nums[start]);
                start++;
                end--;
            }
        }
        k = k % n;
        reverse(0,n-1);
        reverse(0,k-1);
        reverse(k, n -1);
    }
}