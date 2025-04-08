public class Solution {
    public int MinimumOperations(int[] nums) {
        var set = new HashSet<int>();
        var ls = new List<int>();
        foreach(int num in nums){
            set.Add(num);
            ls.Add(num);
        }
        if(nums.Length == set.Count)
            return 0;
        
        var ops = 0;
        while(containsDup(ls)){
            ops++;
            if(ls.Count >= 3){
                ls.RemoveRange(0,3);
            }else
                ls.Clear();
            if(ls.Count == 0)
                break;
        }
        return ops;
    }

    private bool containsDup(List<int> ls){
        var set = new HashSet<int>();
        foreach(int num in ls){
            set.Add(num);
        }
        return ls.Count != set.Count;
    }
}