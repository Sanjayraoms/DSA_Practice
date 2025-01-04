public class TreeNode{
    public int start;
    public int end;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int s, int e, TreeNode left = null, TreeNode right = null){
        start = s;
        end = e;
    }
}
public class Calendar{
    public TreeNode root;
    public Calendar(TreeNode node = null){
        root = node;
    }

    public bool Insert(TreeNode node){
        if(root == null){
            root = node;
            return true;
        }
        var currNode = root;
        while(currNode != null){
            if(node.end <= currNode.start){
                if(currNode.left == null){
                    currNode.left = node;
                    return true;
                }
                currNode = currNode.left;
            }
            else if(node.start >= currNode.end){
                if(currNode.right == null){
                    currNode.right = node;
                    return true;
                }
                currNode = currNode.right;
            }else
                break;
        }
        return false;
    }
}
public class MyCalendar {
    public Calendar cal;
    public MyCalendar() {
        cal = new Calendar();
    }
    
    public bool Book(int startTime, int endTime) {
        var node = new TreeNode(startTime,endTime);
        return cal.Insert(node);
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(startTime,endTime);
 */