public class Solution {
    public string ClearStars(string s) {
        var pq = new PriorityQueue<int,(int x,int y)>();
        var sb = new StringBuilder("");
        var remove = new int[s.Length];

        for(int i = 0; i < s.Length; i++){
            if(s[i] != '*'){
                pq.Enqueue(i,(s[i]-'a',-i));
            }else if(pq.Count > 0){
                remove[i] = 1;
                var idx = pq.Dequeue();
                remove[idx] = 1; 
            }
        }
        for(int i = 0; i < s.Length; i++){
            if(remove[i] != 1)
                sb.Append(s[i]);
        }
        return sb.ToString();
    }
}