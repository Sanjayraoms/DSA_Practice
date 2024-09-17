public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        Dictionary<string,int> str1Ctr = new Dictionary<string,int>();
        List<string> uncommon = new List<string>();
        foreach(string str in s1.Split(' ')){
            if(!str1Ctr.ContainsKey(str))
               str1Ctr[str] = 1;
            else{
                str1Ctr[str]++;
            }
        }
        foreach(string str in s2.Split(' ')){
            if(!str1Ctr.ContainsKey(str))
               str1Ctr[str] = 1;
            else{
                str1Ctr[str]++;
            }
        }
        foreach(string key in str1Ctr.Keys){
            if(str1Ctr[key] == 1)
               uncommon.Add(key);
        }
        return uncommon.ToArray();
    }
}