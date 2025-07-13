public class Solution {
    public int MaxProfit(int[] prices) {
        var buy_price = prices[0];
        var res = 0;

        for(int i = 0; i < prices.Length; i++){
            if(prices[i] < buy_price){
                buy_price = prices[i];
            }else{
                res += prices[i] - buy_price;
                buy_price = prices[i];
            }
        }
        return res;
    }
}