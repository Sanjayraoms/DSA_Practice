public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum) {
        int cnt = 0;
        int sum = 0;
        HashSet<int> bannedSet = new HashSet<int>();
        foreach(int val in banned){
            bannedSet.Add(val);
        }
        for(int i = 1; i <= n ; i++){
            if(!bannedSet.Contains(i)){
                sum += i;
                if(sum <= maxSum){
                    cnt++;
                }else
                    break;
            }
        }
        return cnt;
    }
}