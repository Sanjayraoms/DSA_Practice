public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        int k = nums[0].Length - 1;
        double len = 0;
        while(k >= 0){
            len = len + Math.Pow(2,k);
            k--;
        }
        int[] allPossible = new int[(int)len+1];
        k = nums[0].Length;
        foreach(string s in nums){
            var num = Convert.ToInt32(s,2);
            allPossible[num] = 1;
        }
        for(int i = 0; i < allPossible.Length; i++){
            if(allPossible[i] == 0){
                var res = Convert.ToString(i,2);
                return res.PadLeft(k,'0');
            }
        }
        return "";
    }
}