public class Solution {
    public int TotalFruit(int[] fruits) {
        int maxTree = 0;
        int cnt = 0;
        Dictionary<int,int> basket = new();

        for(int i = 0; i < fruits.Length; i++){
            if(basket.ContainsKey(fruits[i]))
                basket[fruits[i]]++;
            else
                basket[fruits[i]] = 1;
            while(basket.Count > 2){
                var key = fruits[i - cnt];
                basket[key]--;
                if(basket[key] == 0)
                    basket.Remove(key);
                cnt--;
            }
            cnt++;
            maxTree = Math.Max(cnt, maxTree);
        }

        return maxTree;
    }
}