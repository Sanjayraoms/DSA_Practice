public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        var lesser = new List<int>();
        var same = new List<int>();
        var larger = new List<int>();

        foreach(int num in nums){
            if(num < pivot)
                lesser.Add(num);
            else if(num == pivot)
                same.Add(num);
            else
                larger.Add(num);
        }
        lesser.AddRange(same);
        lesser.AddRange(larger);

        return lesser.ToArray();
    }
}