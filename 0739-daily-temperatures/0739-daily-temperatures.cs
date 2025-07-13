public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var res = new int[temperatures.Length];
        Stack<int[]> st = new();

        for(int i = 0; i < temperatures.Length; i++){
            var t = temperatures[i];

            while(st.Count > 0 && t > st.Peek()[1]){
                var p = st.Pop();
                res[p[0]] = i - p[0];
            }
            st.Push(new int[]{i, temperatures[i]});
        }

        return res;
    }
}