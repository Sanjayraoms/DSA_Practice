public class Solution {
    int suffixCnt;
    int prefixCnt;
    public bool AreSentencesSimilar(string sentence1, string sentence2) {
        var sen1 = sentence1.Split(" ");
        var sen2 = sentence2.Split(" ");
        prefixCnt = 0;
        string newStr;
        for(int i = 0; i< Math.Min(sen1.Length,sen2.Length); i++){
            if(sen1[i] == sen2[i])
                prefixCnt++;
            else
                break;
        }
        if(prefixCnt == Math.Min(sen1.Length,sen2.Length))
            return true;
        if(sen1.Length >= sen2.Length){
            suffixCnt = getSuffixCnt(sen1,sen2);
            if(suffixCnt == Math.Min(sen1.Length,sen2.Length) || (suffixCnt+prefixCnt > Math.Min(sen1.Length,sen2.Length)))
                return true;
            newStr = buildString(sen1);
            if(newStr.Trim() == sentence2)
                return true;
        }else{
            suffixCnt = getSuffixCnt(sen2,sen1);
            if(suffixCnt == Math.Min(sen1.Length,sen2.Length) || (suffixCnt+prefixCnt > Math.Min(sen1.Length,sen2.Length)))
                return true;
            newStr = buildString(sen2);
            if(newStr.Trim() == sentence1)
                return true;
        }
        return false;
    }

    private int getSuffixCnt(string[] big, string[] small){
        suffixCnt = 0;
        int i = big.Length - 1;
        int j = small.Length - 1;
        for(int k = i; j >=0 ; k--){
            if(big[k] == small[j])
                suffixCnt++;
            else
                break;
            j--;
        }
        return suffixCnt;
    }
    private string buildString(string[] str){
        StringBuilder sb = new StringBuilder("");
        int i = 0;
        while(i < prefixCnt){
            sb.Append($"{str[i]} ");
            i++;
        }
        i = str.Length - suffixCnt;
        while(i < str.Length){
            sb.Append($"{str[i]} ");
            i++;
        }
        return sb.ToString();
    }
}