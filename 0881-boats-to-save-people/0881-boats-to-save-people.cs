public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        int totBoats = 0;
        Array.Sort(people);
        int left = 0;
        int right = people.Length - 1;
        while(left <= right){
            if((people[left] + people[right]) <= limit){
                left++;
            }
            right--;
            totBoats++;
        }
        return totBoats;
    }
}