public class Solution {
    public int MaxProfit(int[] prices) {
        int buy_Price = prices[0];
        int max_Price = 0;
        for(int i = 0; i < prices.Length; i++){
            if(prices[i] < buy_Price){
                buy_Price = prices[i];
            }else{
                max_Price = Math.Max(max_Price,prices[i] - buy_Price);
            }
        }
        return max_Price;
    }
}