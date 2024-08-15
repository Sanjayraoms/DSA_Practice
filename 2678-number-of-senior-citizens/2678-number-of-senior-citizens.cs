public class Solution {
    public int CountSeniors(string[] details) {
        int totSnr = 0;
        int x;
        foreach(string detail in details){
            if(Int32.Parse(detail.Substring(11,2)) > 60){
                totSnr++;
            } 
        }
        return totSnr;
    }
}