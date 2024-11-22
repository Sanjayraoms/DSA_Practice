public class Solution {
    public int MaxEqualRowsAfterFlips(int[][] matrix) {
        Dictionary<string,int> allPatterns = new Dictionary<string,int>();
        StringBuilder sb = new StringBuilder();
        int flips = 0;
        foreach(int[] row in matrix){
            sb.Clear();
            if(row[0] == 0){
                foreach(int item in row)
                    sb.Append(item);
            }else{
                foreach(int item in row)
                    sb.Append(item^1);
            }
            var key = sb.ToString();
            if(allPatterns.ContainsKey(key))
                allPatterns[key]++;
            else
                allPatterns[key] = 1;
        }
        foreach(int val in allPatterns.Values){
            flips = Math.Max(flips,val);
        }
        return flips;
    }
}