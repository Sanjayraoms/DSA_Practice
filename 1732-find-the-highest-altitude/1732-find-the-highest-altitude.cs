public class Solution {
    public int LargestAltitude(int[] gain) {
        int ha = int.MinValue;
        int[] prefixSum = new int[gain.Length];
        prefixSum[0] = gain[0];
        ha = Math.Max(ha,prefixSum[0]);
        for(int i = 1; i < gain.Length; i++){
            prefixSum[i] = prefixSum[i - 1] + gain[i];
            ha = Math.Max(ha,prefixSum[i]);
        }
        return Math.Max(0,ha);
    }
}