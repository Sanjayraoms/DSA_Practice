public class Solution {
    public IList<string> StringMatching(string[] words) {
        var res = new List<string>();
        for(int i = 0; i < words.Length; i++){
            for(int j = 0; j < words.Length; j++){
                if(i!=j && words[j].IndexOf(words[i]) >= 0){
                    res.Add(words[i]);
                    break;
                }
            }
        }
        return res;
    }
}