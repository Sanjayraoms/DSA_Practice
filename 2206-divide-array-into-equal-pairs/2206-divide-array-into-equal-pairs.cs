public class Solution {
    public bool DivideArray(int[] nums) {
        var dict = new Dictionary<int,int>();
        foreach(int num in nums){
            if(dict.ContainsKey(num)){
                dict[num]--;
                dict.Remove(num);
            }else
                dict[num] = 1;
        }
        return dict.Count == 0;
    }
}