public class Solution {
    public string ReverseVowels(string s) {
        var charArr = s.ToCharArray();
        int i = 0;
        int j = charArr.Length - 1;
        while(i < j){
            if(isVowel(charArr[i]) && isVowel(charArr[j])){
                var temp = charArr[i];
                charArr[i] = charArr[j];
                charArr[j] = temp;
                i++;
                j--;
            }else{
                if(!isVowel(charArr[i]))
                   i++;
                if(!isVowel(charArr[j]))
                   j--;
            }
        }
        return new String(charArr);
    }
    private bool isVowel(char c){
        if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c== 'u' ||
           c == 'A' || c == 'E' || c == 'I' || c == 'O' || c== 'U')
           return true;
        return false;
    }
}