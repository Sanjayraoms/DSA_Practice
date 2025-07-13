public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
        int matches = 0;
        Array.Sort(players);
        Array.Sort(trainers);
        int p = 0, t = 0;

        while(p < players.Length && t < trainers.Length){
            if(players[p] <= trainers[t]){
                matches++;
                p++;
                t++;
            }else
                t++;
        }
        return matches;
    }
}