public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        IList<int> distinctNums1 = new List<int>();
        IList<int> distinctNums2 = new List<int>();
        HashSet<int> s1 = new HashSet<int>(nums1);
        HashSet<int> s2 = new HashSet<int>(nums2);
        foreach(var x in s1){
            if(!s2.Contains(x))
               distinctNums1.Add(x);
        }
        foreach(var x in s2){
            if(!s1.Contains(x))
               distinctNums2.Add(x);
        }
        var res = new List<IList<int>>();
        res.Add(distinctNums1);
        res.Add(distinctNums2);
        return res;
        

    }
}