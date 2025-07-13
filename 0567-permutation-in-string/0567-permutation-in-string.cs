public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char,int> permFreq = new Dictionary<char,int>();
        foreach(char c in s1){
            if(!permFreq.ContainsKey(c))
                permFreq[c] = 1;
            else
                permFreq[c]++;
        }
        var clonedDict = new Dictionary<char,int>(permFreq);
        for(int i=0; i < s2.Length; i++){
            if(clonedDict.ContainsKey(s2[i])){
                clonedDict[s2[i]]--;
                if(clonedDict[s2[i]] == 0){
                    clonedDict.Remove(s2[i]);
                }
                if(clonedDict.Count == 0)
                    return true;
            }else{
                clonedDict = new Dictionary<char,int>(permFreq);;
            }
        }
        clonedDict = new Dictionary<char,int>(permFreq);
        for(int i=s2.Length-1; i >= 0; i--){
            if(clonedDict.ContainsKey(s2[i])){
                clonedDict[s2[i]]--;
                if(clonedDict[s2[i]] == 0){
                    clonedDict.Remove(s2[i]);
                }
                if(clonedDict.Count == 0)
                    return true;
            }else{
                clonedDict = new Dictionary<char,int>(permFreq);;
            }
        }
        return false;
    }
}