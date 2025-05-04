public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        var freq = new int[7];
        var minSwaps = int.MaxValue;
        for(int i = 0; i < tops.Length; i++){
            freq[tops[i]]++;
            freq[bottoms[i]]++;
        }
        for(int i = 0 ;i< freq.Length; i++){
            if(freq[i] >= tops.Length){
                var l = checkSwaps(tops,bottoms,i);
                var m = checkSwaps(bottoms,tops,i);
                minSwaps = Math.Min(minSwaps,Math.Min(l,m));
            }
        }
        return minSwaps == int.MaxValue ? -1 : minSwaps;
    }
    private int checkSwaps(int[] nochng, int[] chng, int num){
        int res = 0;
        for(int i = 0; i < nochng.Length; i++){
            if(nochng[i] != num && chng[i] == num)
                res++;
            else if(nochng[i] == num){
                //do nothing
            }
            else
                return int.MaxValue;
        }
        return res;
    }
}