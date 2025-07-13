public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        var dict = new Dictionary<string,int>();
        int r = 0;

        foreach(var domino in dominoes){
            var comb1 = $"{domino[0]}{domino[1]}";
            var comb2 = $"{domino[1]}{domino[0]}";
            if(dict.ContainsKey(comb1)){
                dict[comb1]++;
            }else if(dict.ContainsKey(comb2)){
                dict[comb2]++;
            }else
                dict[comb1] = 1;
        }

        foreach(var key in dict.Keys){
            if(dict[key] > 1)
              r += (dict[key]*(dict[key]-1))/2;
        }

        return r;
    }
}