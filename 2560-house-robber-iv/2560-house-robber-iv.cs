public class Solution {
    public int MinCapability(int[] nums, int k) {
        int max = nums.Max();
        int min = nums.Min();
        int mid = 0;
        int res = 0;

        while(min <= max){
            mid = (min + max)/2;
            if(canPick(nums,k,mid)){
                res = mid;
                max = mid-1;
            }else{
                min = mid + 1;
            }
        }
        return res;
    }
    private bool canPick(int[] nums,int k, int mid){
        var counter = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] <= mid){
                counter++;
                i++;
            }
        }
        return counter == k;
    }
}