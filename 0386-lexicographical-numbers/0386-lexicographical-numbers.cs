public class Solution {
    public IList<int> LexicalOrder(int n) {
        List<int> lexicoGraphical = new List<int>();
        int current = 1;
        for(int i = 0; i < n; ++i){
            lexicoGraphical.Add(current);

            if(current*10 <= n)
                current *= 10;
            else{
                while(current % 10 == 9 || current >= n){
                    current /= 10;
                }
                current++;
            }
        }
        return lexicoGraphical;
    }
}