public class Solution {
    public bool CheckIfExist(int[] arr) {
        Array.Sort(arr);
        if(arr.Length == 2)
            return arr[1] == 2 * arr[0];
        for(int i = 0; i < arr.Length - 1; i++){
            var target = 2 * arr[i];
            var indx = binarySearch(arr,target);
            if(indx > -1 && indx != i)
                return true;
        }
        return false;
    }
    public int binarySearch(int[] arr,int target){
        int left = 0;
        int right = arr.Length - 1;
         
        while(left <= right){
            var mid = (left+right)/2;
            if(arr[mid] < target){
                left = mid + 1;
            }else if(arr[mid] > target){
                right = mid - 1;
            }else{
                return mid;
            }
        }
        return -1;
    }
}