public class Solution {
    public string CompressedString(string word) {
        StringBuilder sb = new StringBuilder();
        int currCnt = 1;
        char currChar = word[0];
        for(int i = 1; i < word.Length; i++){
            if(word[i] != currChar || currCnt == 9){
                sb.Append($"{currCnt}{currChar}");
                currChar = word[i];
                currCnt = 1;
            }else{
                currCnt++;
            }
        }
        sb.Append($"{currCnt}{currChar}");
        return sb.ToString();
    }
}