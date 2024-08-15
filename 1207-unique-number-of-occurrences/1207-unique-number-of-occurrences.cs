public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int> occurences = new Dictionary<int,int>();
        List<int> freq = new List<int>(); 
        foreach(int item in arr){
            if(!occurences.ContainsKey(item))
               occurences[item] = 1;
            else
               occurences[item] += 1;
        }
        foreach(int key in occurences.Keys)
           freq.Add(occurences[key]);
        if(freq.GroupBy(x=>x).Where(g=>g.Count() > 1).Count() > 0)
           return false;
        else
           return true;
    }
}