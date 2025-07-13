public class Solution {
    public int FindJudge(int n, int[][] trust) {
        var outgoing = new int[n+1];
        var incoming = new int[n+1];

        foreach(var tr in trust){
            outgoing[tr[0]]++;
            incoming[tr[1]]++;
        }

        for(int i = 1; i < outgoing.Length; i++){
            if(outgoing[i] == 0 && incoming[i] == n-1)
                return i;
        }
        return -1;
    }
}