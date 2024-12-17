public class Solution {
    public string RepeatLimitedString(string s, int repeatLimit) {
        int[] freq = new int[26];
        string alphabets = "abcdefghijklmnopqrstuvwxyz";
        StringBuilder res = new StringBuilder();
        var pq = new PriorityQueue<char,(int chVal, int freq)>();
        foreach(char ch in s){
            freq[ch-'a']++;
        }
        for(int i = 0; i < freq.Length; i++){
            if(freq[i] > 0){
                pq.Enqueue(alphabets[i],(-i,freq[i]));
            }
        }
        while(pq.Count > 0){
            var dq = pq.Dequeue();
            if(res.Length > 0 && dq == res[^1])
                break;
            var currCharfreq = freq[dq-'a'];
            var rate = Math.Min(currCharfreq,repeatLimit);
            freq[dq-'a'] = currCharfreq - rate;
            for(int i = 0; i < rate; i++){
                res.Append(dq);
            }
            if(freq[dq-'a'] > 0 && pq.Count > 0){
                var ndq = pq.Dequeue();
                res.Append(ndq);
                freq[ndq - 'a']--;
                if (freq[ndq - 'a'] > 0)
                {
                    var npr = ndq - 'a';
                    pq.Enqueue(ndq, (-npr, freq[ndq - 'a']));
                }
            }
            if(freq[dq-'a'] > 0){
                var pr = dq-'a';
                pq.Enqueue(dq,(-pr,freq[dq-'a']));
            }
        }
        return res.ToString();
    }
}