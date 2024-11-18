public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int len = code.Length;
        int[] res = new int[len];
        if(k==0)
            return res;
        int start = 1, end = k, sum = 0;
        if(k<0){
            start = len - Math.Abs(k);
            end = len - 1;
        }
        for(int i = start; i <= end; i++){
            sum += code[i];
        }
        for(int j = 0; j < len; j++){
            res[j] = sum;
            sum += code[(end+1) % len];
            sum -= code[start % len];
            start++;
            end++;
        }
        return res;
    }
}