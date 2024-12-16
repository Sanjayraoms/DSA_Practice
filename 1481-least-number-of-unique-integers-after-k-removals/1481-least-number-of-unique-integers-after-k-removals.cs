public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) {
        Dictionary<int,int> freq = new Dictionary<int,int>();
        foreach(int num in arr){
            if(freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }
        int[] freqs = new int[freq.Count];
        int j = 0;
        foreach(int val in freq.Values){
            freqs[j++] = val; 
        }
        Array.Sort(freqs);
        int res = 0;
        for(int i = 0; i < freqs.Length; i++){
            if(freqs[i] < k)
                k = k - freqs[i];
            else if(freqs[i] == k){
                res = freqs.Length - i - 1;
                break;
            }
            else{
                res = freqs.Length - i;
                break;
            }
        }
        return res;
    }
}