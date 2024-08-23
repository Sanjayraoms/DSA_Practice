public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        List<int> stack = new List<int>();
        int last;
        stack.Add(asteroids[0]);
        for(int i=1; i < asteroids.Length; i++){
            if(asteroids[i] > 0 || stack.Count == 0)
               stack.Add(asteroids[i]);
            else{
                last = stack[^1];
                if(last < 0){
                    stack.Add(asteroids[i]);
                    continue;
                }
                while(last > 0){
                    if(Math.Abs(last) < Math.Abs(asteroids[i])){
                        stack.RemoveAt(stack.Count - 1); 
                        last = 0;
                    }else if(Math.Abs(last) == Math.Abs(asteroids[i])){
                        stack.RemoveAt(stack.Count - 1);
                        break;
                    }else
                        break;
                    if(stack.Count > 0)
                        last = stack[^1];   
                }
                if(last <= 0)
                   stack.Add(asteroids[i]);
            }
        }
        return stack.ToArray();
    }
}