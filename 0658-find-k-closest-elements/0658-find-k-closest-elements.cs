public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        int l = 0;
        int r = arr.Length - k;

        while(l < r){
            int mid = (l+r)/2;
            if(x - arr[mid] > arr[mid+k] - x){
                l = mid + 1;
            }else
                r = mid;
        }
        var res = new List<int>();
        for(int i = l; i < l+k; i++){
            res.Add(arr[i]);
        }
        return res;
    }
}