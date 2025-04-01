public class Solution {
    public long MostPoints(int[][] questions) {
        var cache = new long[questions.Length];

        long dp(int i){
            if(i >= questions.Length)
                return 0;
            if(cache[i] > 0)
                return cache[i];
            var tp = (questions[i][0],questions[i][1]);
            cache[i] = Math.Max(
                dp(i+1),
                tp.Item1 + dp(i+1+tp.Item2)
            );
            return cache[i];
        }
        return dp(0);
    }
}