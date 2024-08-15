public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        Dictionary<int,int> ctr = new Dictionary<int,int>();
        for(int i = 0; i< target.Length; i++){
            if(ctr.ContainsKey(target[i]))
               ctr[target[i]]++;
            else
               ctr.Add(target[i],1);
        }
        for(int j = 0; j < arr.Length; j++){
            if(ctr.ContainsKey(arr[j])){
                ctr[arr[j]]--;
                if(ctr[arr[j]] == 0)
                   ctr.Remove(arr[j]);
            }
            else
               return false;
        }
        return true;
    }
}