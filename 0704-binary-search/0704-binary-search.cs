public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length;
        int pivot = 0;

        while(left <= right){
            pivot = (left + right) / 2;
            if(pivot < 0 || pivot >= nums.Length)
                return -1;
            if(nums[pivot] == target)
                return pivot;
            if(nums[pivot] > target)
                right = pivot - 1;
            else
                left = pivot + 1;
        }
        return -1;
    }
}