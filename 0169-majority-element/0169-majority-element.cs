public class Solution {
    public int MajorityElement(int[] nums) {
        int nby2 = (int)Math.Floor((double)(nums.Length/2)); 
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int num in nums){
            if(map.ContainsKey(num)){
                map[num] += 1;
            }else{
                map[num] = 1;
            }
            if(map[num] > nby2){
                return num;
            }
        }
        return 0;
    }
}