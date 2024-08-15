public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        Dictionary<int,string> people = new Dictionary<int,string>();
        string name;
        List<string> namesOrder = new List<string>();
        for(int i = 0; i < names.Length; i++){
            people.Add(heights[i],names[i]);
        }
        Array.Sort(heights);
        for(int i = heights.Length - 1; i >= 0; i--){
            if(people.TryGetValue(heights[i],out name)){
                namesOrder.Add(name);
            }
        }
        return namesOrder.ToArray();
    }
}