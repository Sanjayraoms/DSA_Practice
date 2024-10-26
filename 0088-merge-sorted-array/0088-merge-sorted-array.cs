public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        List<int> buff = new List<int>();
        int i = 0;
        int j = 0;
        while(i < m && j < n){
            if(nums1[i] <= nums2[j]){
                buff.Add(nums1[i]);
                i++;
            }else{
                buff.Add(nums2[j]);
                j++;
            }
        }
        while(i< m){
            buff.Add(nums1[i]);
            i++;
        }
        while(j < n){
            buff.Add(nums2[j]);
            j++;
        }
        for(int k = 0; k <buff.Count; k++){
            nums1[k] = buff[k];
        }
    }
}