public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var visited = new HashSet<int>();
        var st = new Stack<int>();
        st.Push(0);
        while(st.Count > 0){
            var curr = st.Pop();
            visited.Add(curr);
            foreach(var key in rooms[curr]){
                if(!visited.Contains(key))
                    st.Push(key);
            }
        }
        
        return visited.Count == rooms.Count;
    }
}