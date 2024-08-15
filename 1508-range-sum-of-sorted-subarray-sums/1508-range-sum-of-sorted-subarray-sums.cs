public class Solution {
    public int RangeSum(int[] nums, int n, int left, int right) {
        List<int> sums = new List<int>();
        int prevSum = 0;
        int iterator = 0;
        int result = 0;
         for(int i = 0; i < nums.Length; i++){
            prevSum = nums[i];
            sums.Add(prevSum);
            iterator = i+1;
            while(iterator < n){
                prevSum = prevSum + nums[iterator];
                sums.Add(prevSum);
                iterator++;
            }
         }
         sums.Sort();
         int[] sum = sums.ToArray();
         for(int j = (left-1); j < right;j++){
            result += sum[j];
            result = result % 1000000007;
         }
         return result;
    }
}