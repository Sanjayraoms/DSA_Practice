public class Solution {
    public string TriangleType(int[] nums) {
        // Array.Sort(nums);
        // if(nums[0]+nums[1] <= nums[2])
        //     return "none";
        // else if(nums[0] == nums[2])
        //     return "equilateral";
        // else if(nums[0] == nums[1] || nums[1] == nums[2])
        //     return "isosceles";
        // else
        //     return "scalene";
        if(nums[0] == nums[1] && nums[1] == nums[2])
            return "equilateral";

        if((nums[0]+nums[1] > nums[2]) &&
           (nums[0]+nums[2] > nums[1]) &&
           (nums[1]+nums[2] > nums[0])){
            if(nums[0] != nums[1] && nums[1] !=nums[2] && nums[2] != nums[0])
                return "scalene";
            if(nums[0] == nums[1] ||
               nums[0] == nums[2] ||
               nums[1] == nums[2])
                return "isosceles";
           }
        return "none";
        
    }
}