public class Solution {
    public IList<string> StringSequence(string target) {
        List<String> allStr = new List<String>();
        StringBuilder bldr = new StringBuilder("");
        int currCharIndx = 0;
        while(currCharIndx < target.Length){
            if(bldr.Length <= currCharIndx){
                bldr.Append('a');
                allStr.Add(bldr.ToString());
            }else if(bldr[currCharIndx] != target[currCharIndx]){
                bldr[currCharIndx] = (Char)(Convert.ToInt16(bldr[currCharIndx]) + 1);
                allStr.Add(bldr.ToString());
            }else
                currCharIndx++;
        }
        return allStr;
    }
}