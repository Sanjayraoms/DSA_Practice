public class Solution {
    public bool CanBeValid(string s, string locked) {
        if(s.Length % 2 == 1)
            return false;
        Stack<int> locked_c = new Stack<int>();
        Stack<int> unlocked = new Stack<int>();

        for(int i = 0; i < s.Length; i++){
            if(locked[i] == '0')
                unlocked.Push(i);
            else if(s[i] == '('){
                locked_c.Push(i);
            }else{
                if(locked_c.Count > 0)
                    locked_c.Pop();
                else if(unlocked.Count > 0)
                    unlocked.Pop();
                else
                    return false;
            }
        }
        while(locked_c.Count > 0 && unlocked.Count > 0 && locked_c.Peek() < unlocked.Peek()){
            locked_c.Pop();
            unlocked.Pop();
        }
        return locked_c.Count == 0;
    }
}