public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0; int r = nums.Length - 1;

        while(l < r){
            int pivot = (l+r)/2;
            if(nums[pivot] < target)
                l = pivot + 1;
            else
                r = pivot;
        }
        return nums[l] == target ? l : -1;
    }
}