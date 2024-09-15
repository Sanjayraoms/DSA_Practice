public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int[] sneaky = new int[2];
        int indx = 0;
        foreach(int num in nums){
            if(map.ContainsKey(num)){
                sneaky[indx] = num;
                indx++;
            }else
               map[num] = 1;
        }
        return sneaky;
    }
}