public class Solution {
    public int MaximumSwap(int num) {
        var numArr = num.ToString().ToCharArray();
        int n = numArr.Length - 1;
        int maxRightIndx = n;
        for(int i = n-1; i>0; i--){
            if(numArr[i] > numArr[maxRightIndx]){
                maxRightIndx = i;
            }
        }
        for(int i = 0; i<=n;i++){
            if(maxRightIndx>i && numArr[i]<numArr[maxRightIndx]){
                (numArr[i],numArr[maxRightIndx]) = (numArr[maxRightIndx],numArr[i]);
                return int.Parse(new String(numArr));
            }
        }
        return num;
    }
}