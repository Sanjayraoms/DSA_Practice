public class Solution {
    public string MakeFancyString(string s) {
        char[] chrArr = s.ToCharArray();
        for(int i = 1; i < chrArr.Length - 1; i++){
            if(chrArr[i-1] == chrArr[i] && chrArr[i] == chrArr[i+1]){
                chrArr[i-1] = ' ';
            }
        }
        return new string(new string(chrArr).Where(x => !char.IsWhiteSpace(x)).ToArray());
    }
}