public class Solution {
    public int MaximumLength(string s) {
        int[][] freq = new int[26][];
        for(int i = 0; i < freq.Length; i++){
            freq[i] = new int[3];
            Array.Fill(freq[i],-1);
        }
        int curr_max = 0;
        char curr_char = '*';
        foreach(char ch in s){
            var idx = ch - 'a';
            curr_max = (ch == curr_char) ? curr_max + 1 : 1;
            curr_char = ch;
            var min = getMin(freq[idx][0],freq[idx][1],freq[idx][2]);
            if(curr_max > freq[idx][min]){
                freq[idx][min] = curr_max;
            }
        }
        curr_max = -1;
        foreach(int[] arr in freq){
            curr_max = Math.Max(curr_max,Math.Min(arr[0],Math.Min(arr[1],arr[2])));
        }
        return curr_max;
    }
    public int getMin(int a, int b, int c){
        if(a<=b && a<=c) return 0;
        if(b<=a && b<=c) return 1;
        return 2;
    }
}