public class Solution {
    public void SortColors(int[] nums) {
        int[] freq = new int[3];
        foreach (int num in nums)
        {
            freq[num]++;
        }
        int indx = 0;
        for (int i = 0; i < freq.Length; i++)
        {
            while(freq[i]>0){
                nums[indx] = i;
                freq[i]--;
                indx++;
            }
        }
    }
}