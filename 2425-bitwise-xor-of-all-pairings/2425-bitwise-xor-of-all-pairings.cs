public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        Dictionary<int,int> freq = new Dictionary<int,int>();
        int len2 = nums2.Length;
        int len1 = nums1.Length;
        int res = 0;
        for(int i = 0; i < nums1.Length; i++){
            if(freq.ContainsKey(nums1[i]))
                freq[nums1[i]] += len2;
            else
                freq[nums1[i]] = len2;
        }

        for(int i = 0; i < nums2.Length; i++){
            if(freq.ContainsKey(nums2[i]))
                freq[nums2[i]] += len1;
            else
                freq[nums2[i]] = len1;
        }

        foreach(int key in freq.Keys){
            if(freq[key] % 2 == 1)
                res = res ^ key;
        }

        return res;
    }
}