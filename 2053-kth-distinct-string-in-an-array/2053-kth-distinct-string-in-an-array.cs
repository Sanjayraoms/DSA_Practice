public class Solution {
    public string KthDistinct(string[] arr, int k) {
        Dictionary<string,int> map = new Dictionary<string,int>();
        int cntr = 0;

        for(int i = 0; i < arr.Length; i++){
            if(map.ContainsKey(arr[i]))
               map[arr[i]]++;
            else
               map[arr[i]] = 1;
        }
        foreach(string key in map.Keys){
            if(map[key] == 1){
                cntr++;
                if(cntr == k)
                  return key;
            }     
        }

        return "";
    }
}