public class Solution {
    public long DividePlayers(int[] skill) {
        if(skill.Length == 2){
            return skill[0]*skill[1];
        }
        Array.Sort(skill);
        int i = 0;
        int j = skill.Length - 1;
        int skillTotal = skill[i]+skill[j];
        long chemistry = skill[i] * skill[j];
        i++;
        j--;
        while(i<j){
            if(skill[i]+skill[j] != skillTotal)
                return -1;
            else{
                chemistry = chemistry + (skill[i] * skill[j]);
            }
            i++;
            j--;
        }
        return chemistry;    
    }
}