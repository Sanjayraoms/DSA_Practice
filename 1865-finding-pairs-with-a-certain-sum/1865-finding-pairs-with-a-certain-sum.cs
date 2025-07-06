public class FindSumPairs {
    private int[] _nums1;
    private int[] _nums2;
    private Dictionary<int,int> cnt;
    public FindSumPairs(int[] nums1, int[] nums2) {
        _nums1 = nums1;
        _nums2 = nums2;
        cnt = new();
        foreach(int num in _nums2){
            if(cnt.ContainsKey(num))
                cnt[num]++;
            else
                cnt[num] = 1;
        }
    }
    
    public void Add(int index, int val) {
        int oldVal = _nums2[index];
        cnt[oldVal]--;
        _nums2[index] += val;

        if(cnt.ContainsKey(_nums2[index]))
            cnt[_nums2[index]]++;
        else
            cnt[_nums2[index]] = 1;
    }
    
    public int Count(int tot) {
        int res = 0;
        foreach(int num in _nums1){
            var key = tot - num;
            if(cnt.ContainsKey(key))
                res += cnt[key];
        }
        return res;
    }
}

/**
 * Your FindSumPairs object will be instantiated and called as such:
 * FindSumPairs obj = new FindSumPairs(nums1, nums2);
 * obj.Add(index,val);
 * int param_2 = obj.Count(tot);
 */