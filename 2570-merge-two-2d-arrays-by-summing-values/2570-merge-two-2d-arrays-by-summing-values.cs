public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        var res = new List<int[]>();
        int i = 0; int j = 0;
        while(i < nums1.Length && j < nums2.Length){
            if(nums1[i][0] == nums2[j][0]){
                res.Add(new int[]{nums1[i][0],nums1[i][1] + nums2[j][1]});
                i++;
                j++;
            }else if(nums1[i][0] < nums2[j][0]){
                res.Add(new int[]{nums1[i][0],nums1[i][1]});
                i++;
            }else if(nums2[j][0] < nums1[i][0]){
                res.Add(new int[]{nums2[j][0],nums2[j][1]});
                j++;
            }
        }
        while(i < nums1.Length){
            res.Add(new int[]{nums1[i][0],nums1[i][1]});
            i++;
        }
        while(j < nums2.Length){
            res.Add(new int[]{nums2[j][0],nums2[j][1]});
            j++;
        }
        return res.ToArray();
    }
}