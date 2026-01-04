public class Solution {
    public int SumFourDivisors(int[] nums) {
        var res = 0;
        foreach(int num in nums){
            var divisors = new List<int>();
            for(int i = 1; i <= Math.Sqrt(num); i++){
                if(num % i == 0){
                    divisors.Add(i);
                    var l = num / i;
                    if(l != i) divisors.Add(l);
                }
            }
            if(divisors.Count == 4){
                res += divisors.Sum();
            }
        }
        return res;
    }
}