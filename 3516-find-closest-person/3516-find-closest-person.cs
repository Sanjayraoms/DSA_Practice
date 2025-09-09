public class Solution {
    public int FindClosest(int x, int y, int z) {
        int dist1 = Math.Abs(x-z);
        int dist2 = Math.Abs(y-z);
        if(dist1 == dist2)
            return 0;
        return dist1 < dist2 ? 1 : 2;
    }
}