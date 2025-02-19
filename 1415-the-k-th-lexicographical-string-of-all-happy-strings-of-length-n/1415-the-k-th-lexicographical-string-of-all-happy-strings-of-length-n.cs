public class Solution {
    public string GetHappyString(int n, int k) {
        var resSet = new List<string>();
        
        var q = new Queue<string>();
        q.Enqueue("a");
        q.Enqueue("b");
        q.Enqueue("c");

        while(q.Count > 0){
            var curr = q.Dequeue();
            if(curr.Length == n){
                resSet.Add(curr);
                continue;
            }
            if(curr[^1] == 'a'){
                q.Enqueue($"{curr}b");
                q.Enqueue($"{curr}c");
            }else if(curr[^1] == 'b'){
                q.Enqueue($"{curr}a");
                q.Enqueue($"{curr}c");
            }else{
                q.Enqueue($"{curr}a");
                q.Enqueue($"{curr}b");
            }
        }
        if(resSet.Count < k)
            return "";
        return  resSet[k-1];
    }
}