public class MyCalendarTwo {
    List<(int start,int end)> non_overlapping;
    List<(int start,int end)> overlapping;
    public MyCalendarTwo() {
        non_overlapping = new List<(int start,int end)>();
        overlapping = new List<(int start,int end)>();
    }
    
    public bool Book(int startTime, int endTime) {
        foreach(var overlap in overlapping){
            if(!(endTime <= overlap.Item1 || startTime >= overlap.Item2)){
                return false;
            }
        }
        foreach(var nonoverlap in non_overlapping){
            if(!(endTime <= nonoverlap.Item1 || startTime >= nonoverlap.Item2)){
                var s = Math.Max(startTime, nonoverlap.Item1);
                var e = Math.Min(endTime, nonoverlap.Item2);
                overlapping.Add((s,e));
            }
        }
        non_overlapping.Add((startTime,endTime));
        return true;
    }
}

/**
 * Your MyCalendarTwo object will be instantiated and called as such:
 * MyCalendarTwo obj = new MyCalendarTwo();
 * bool param_1 = obj.Book(startTime,endTime);
 */