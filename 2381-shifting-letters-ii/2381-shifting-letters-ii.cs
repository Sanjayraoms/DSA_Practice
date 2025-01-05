public class Solution {
    public string ShiftingLetters(string s, int[][] shifts) {
        string alp = "abcdefghijklmnopqrstuvwxyz";
        StringBuilder sb = new StringBuilder();
        int[] charVal = new int[s.Length];
        for(int i = 0; i < s.Length; i++){
            charVal[i] = s[i] - 'a';
        }
        int[] difArr = new int[s.Length+1];
        foreach(var shift in shifts){
            difArr[shift[1] + 1] += (shift[2] == 1) ? 1 : -1;
            difArr[shift[0]] += (shift[2] == 1) ? -1 : 1;
        }
        int diff = 0;
        for(int j = difArr.Length - 1; j > 0 ;j--){
            diff += difArr[j];
            charVal[j-1] = (charVal[j-1] + diff + 26) % 26;
        }
        foreach(int val in charVal){
            sb.Append(alp[val]);
        }
        return sb.ToString();
    }
}