public class Solution {
    public int TupleSameProduct(int[] nums) {
        var prodFreq = new Dictionary<int,int>();
        int res = 0;

        for(int i = 0; i < nums.Length; i++){
            for(int j = i+1; j < nums.Length; j++){
                var prod = nums[i]*nums[j];
                if(prodFreq.ContainsKey(prod))
                    prodFreq[prod]++;
                else
                    prodFreq[prod] = 1;
            }
        }
        foreach(int val in prodFreq.Values){
            var pairs = (val *(val-1))/2;
            res += (pairs * 8);
        }

        return res;
    }
}