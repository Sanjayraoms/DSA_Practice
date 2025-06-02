public class Solution {
    public int Candy(int[] ratings) {
        var candies = new int[ratings.Length];
        int res = 0;

        Array.Fill(candies,1);
        for(int i = 1; i < candies.Length; i++){
            if(ratings[i] > ratings[i-1]){
                candies[i] = candies[i-1] + 1;
            }
        }

        for(int i = candies.Length-1; i > 0; i--){
            if(ratings[i-1] > ratings[i]){
                candies[i-1] = Math.Max(candies[i-1],candies[i]+1);
            }
            res += candies[i];
        }
        res += candies[0];
        return res;
    }
}