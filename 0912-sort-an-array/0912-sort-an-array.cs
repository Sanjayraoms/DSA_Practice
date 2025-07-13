public class Solution {
    public int[] SortArray(int[] nums) {
        if(nums.Length == 1)
            return nums;
        int mid = (int)Math.Floor((decimal)(nums.Length/2));
        return merge(SortArray(nums.Take(mid).ToArray()),SortArray(nums.Skip(mid).ToArray()));
    }

    public int[] merge(int[] nums1,int[] nums2){
        var res = new List<int>();
        int i = 0, j = 0;
        while(i < nums1.Length && j < nums2.Length){
            if(nums1[i] < nums2[j]){
                res.Add(nums1[i]);
                i++;
            }else{
                res.Add(nums2[j]);
                j++;
            }
        }
        while(i < nums1.Length){
            res.Add(nums1[i]);
            i++;
        }
        while(j < nums2.Length){
            res.Add(nums2[j]);
            j++;
        }
        return res.ToArray();
    }
}