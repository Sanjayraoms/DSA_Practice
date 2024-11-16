public class Solution {
    public int[] ResultsArray(int[] nums, int k) {
        if(k == 1){
            return nums;
        }
        int[] res = new int[nums.Length - k + 1];
        Array.Fill(res,-1);
        int indx = 0;
        for(int i = 0; i <= nums.Length - k; i++){
            var tempk = k;
            var currwin = i;
            while(tempk > 0){
                if(nums[currwin+1] == nums[currwin] + 1){
                    tempk--;
                    if(tempk == 1){
                        res[indx++] = nums[currwin+1];
                        break;
                    }
                }else{
                    res[indx++] = -1;
                    break;
                }
                currwin++;
            }
        }
        return res;
    }
}