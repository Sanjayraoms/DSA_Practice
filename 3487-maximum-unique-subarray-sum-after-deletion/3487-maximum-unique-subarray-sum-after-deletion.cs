public class Solution {
    public int MaxSum(int[] nums) {
        var unique = new HashSet<int>(nums);
        int res = 0;
        bool containsPos = false;
        foreach(int num in unique){
            if(num > 0){
                containsPos = true;
                break;
            }
        }
        if(!containsPos){
            res = int.MinValue;
            foreach(int num in unique){
                res = Math.Max(res,num);
            }
            return res;
        }
        foreach(int num in unique){
            if(num > 0){
                res += num;
            }    
        }
        return res;
    }
}