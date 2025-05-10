public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        long sum1 = 0;
        long sum2 = 0;
        int zero1 = 0;
        int zero2 = 0;

        foreach(int num in nums1){
            sum1 += num;
            if(num == 0){
                sum1++;
                zero1++;
            }
        }

        foreach(int num in nums2){
            sum2 += num;
            if(num == 0){
                sum2++;
                zero2++;
            }
        }

        if((zero1 == 0 && sum2 > sum1)|| 
           (zero2 == 0 && sum1 > sum2))
           return -1;
        return Math.Max(sum1,sum2);
    }
}