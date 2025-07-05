public class Solution {
    public int FindLucky(int[] arr) {
        int res = -1;
        Dictionary<int,int> freq = new();
        foreach(int num in arr){
            if(freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        foreach(int key in freq.Keys){
            if(freq[key] == key)
                res = Math.Max(res,key);
        }
        return res;
    }
}