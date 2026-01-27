public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        int minDiff = int.MaxValue;
        Array.Sort(arr);
        for(int i = 1; i < arr.Length; i++){
            minDiff = Math.Min(minDiff, Math.Abs(arr[i] - arr[i-1]));
        }
        var res = new List<IList<int>>();
        for(int i = 1; i < arr.Length; i++){
            if(Math.Abs(arr[i]-arr[i-1]) == minDiff)
                res.Add(new List<int>{arr[i-1],arr[i]});
        }
        return res;
    }
}