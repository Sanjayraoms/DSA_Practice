public class Solution {
    public int MaximumSum(int[] nums) {
        int max_sum = -1;
        var lookup = new Dictionary<int,int>();

        for(int i = 0; i< nums.Length; i++){
            var digSum = DigitSum(nums[i]);
            if(lookup.ContainsKey(digSum)){
                max_sum = Math.Max(max_sum,lookup[digSum] + nums[i]);
                if(nums[i] > lookup[digSum])
                    lookup[digSum] = nums[i];
            }else
                lookup[digSum] = nums[i];
        }
        return max_sum;
    }

    private int DigitSum(int num){
        int sum = 0;

        while(num > 0){
            sum += num % 10;
            num = num/10;
        }
        return sum;
    }
}