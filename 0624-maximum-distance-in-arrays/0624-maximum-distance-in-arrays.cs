public class Solution {
    public int MaxDistance(IList<IList<int>> arrays) {
        int min = arrays[0][0];
        int max = arrays[0][arrays[0].Count - 1];
        if(arrays.Count == 2){
            var len1 = arrays[0].Count - 1;
            var len2 = arrays[1].Count - 1;
            return Math.Max((arrays[0][len1] - arrays[1][0]),
                            (arrays[1][len2] - arrays[0][0]));
        }
        for(int i = 1; i < arrays.Count; i++){
            var len = arrays[i].Count - 1;
            if(arrays[i][0] < min && arrays[i][len] > max){
                max = Math.Max(max,arrays[i][len]);
            }else{
                min = Math.Min(min,arrays[i][0]);
                max = Math.Max(max,arrays[i][len]);
            }
        }
        return max - min;
    }
}