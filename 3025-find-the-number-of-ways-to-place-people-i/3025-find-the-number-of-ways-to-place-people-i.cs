public class Solution {
    public int NumberOfPairs(int[][] points) {
        int n = points.Length;
        int count = 0;

        for(int i = 0; i < n; i++){
            var pointA = points[i];
            for(int j = 0; j < n; j++){
                if(i == j)
                    continue;
                var pointB = points[j];
                if(!(pointA[0] <= pointB[0] && pointA[1] >= pointB[1]))
                    continue;
                var found = false;
                for(int k = 0; k < n; k++){
                    if(i == k || j == k)
                        continue;
                    var pointC = points[k];
                    if(((pointA[0] <= pointC[0]) && (pointC[0] <= pointB[0])) && 
                       ((pointA[1] >= pointC[1]) && (pointC[1] >= pointB[1])))
                        found = true;
                }
                if(!found)
                    count++;
            }
        }
        return count;
    }
}