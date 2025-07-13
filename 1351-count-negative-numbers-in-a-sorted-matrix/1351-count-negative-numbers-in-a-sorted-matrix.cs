public class Solution {
    public int CountNegatives(int[][] grid) {
        int res = 0;

        foreach(var arr in grid){
            res += binSearch(arr,0);
        }
        return res;
    }

    private int binSearch(int[] arr, int target){
        int l = 0;
        int r = arr.Length;

        while(l < r){
            var pivot = (l+r)/2;
            if(arr[pivot] >= target)
                l = pivot + 1;
            else
                r = pivot;
        }
        return arr.Length - r;
    }
}