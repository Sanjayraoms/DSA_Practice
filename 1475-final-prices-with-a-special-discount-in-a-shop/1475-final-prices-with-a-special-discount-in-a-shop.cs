public class Solution {
    public int[] FinalPrices(int[] prices) {
        Stack<int> monotonic = new Stack<int>();
        for(int i = 0; i< prices.Length; i++){
            while(monotonic.Count > 0){
                if(prices[i]<=prices[monotonic.Peek()]){
                    var curridx = monotonic.Pop();
                    prices[curridx] = prices[curridx] - prices[i];
                }else
                    break;
            }
            monotonic.Push(i);
        }
        return prices;
    }
}