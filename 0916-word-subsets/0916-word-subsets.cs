public class Solution {
    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        var res = new List<string>();
        int[][] dict = new int[words1.Length][];
        Dictionary<char,int> maxfreq = new Dictionary<char,int>();
        for (int i = 0; i < words2.Length; i++)
        {
            var dict2 = new Dictionary<char, int>();
            for (int j = 0; j < words2[i].Length; j++)
            {
                if (dict2.ContainsKey(words2[i][j]))
                    dict2[words2[i][j]]++;
                else
                    dict2[words2[i][j]] = 1;
            }
            foreach(char c in dict2.Keys){
                if(maxfreq.ContainsKey(c)){
                    maxfreq[c] = Math.Max(maxfreq[c],dict2[c]);
                }
                else
                    maxfreq[c] = dict2[c];
            }
        }
        for (int i = 0; i < words1.Length; i++)
        {
            dict[i] = new int[26];
            for (int j = 0; j < words1[i].Length; j++)
            {
                dict[i][words1[i][j] - 'a']++;
            }
            var subset = true;
            foreach (char c in maxfreq.Keys)
            {
                if (dict[i][c - 'a'] < maxfreq[c])
                {
                    subset = false;
                    break;
                }
            }
            if (subset == true)
                res.Add(words1[i]);
        }
        return res;
    }
}