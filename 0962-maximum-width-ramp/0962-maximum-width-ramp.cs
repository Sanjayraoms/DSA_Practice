public class Solution {
    public int MaxWidthRamp(int[] nums) {
        int maxWidth = 0;
        Stack<int> st = new Stack<int>();
        st.Push(nums.Length-1);
        for(int i = nums.Length -2; i >= 0; i--){
            if(nums[i] > nums[st.Peek()]){
                st.Push(i);
            }else{
                foreach(int index in st){
                    if(nums[i]<=nums[index]){
                        maxWidth = Math.Max(maxWidth,index-i);
                    }
                }
            }
        }
        return maxWidth;
    }

}