public class Solution {
    public bool CanChange(string start, string target) {
        int len = start.Length;
        int i = 0;
        int j = 0;
        while(i < len && j < len){
            while(i < len && start[i] == '_'){
                i++;
            }
            while(j < len && target[j] == '_'){
                j++;
            }
            if(start[i] != target[j] ||
               (start[i] == 'L' && i < j) ||
               (start[i] == 'R' && i > j))
               return false;

            i++;
            j++;
        }
        return true;
    }
}