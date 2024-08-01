public class Solution {
    public int CountSeniors(string[] details) {
        int totSnr = 0;
        int x;
        foreach(string detail in details){
            if(Int32.TryParse(detail.Substring(11,2), out x)){
                if(x > 60)
                   totSnr++;
            } 
        }
        return totSnr;
    }
}