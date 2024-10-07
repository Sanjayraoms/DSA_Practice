public class Solution {
    public int MinLength(string s) {
        var str = s.ToArray();
        bool popped; 
        Stack<char> chs = new Stack<char>();
        while(true){
            chs.Clear();
            popped = false;
            foreach(char c in str){
                if(c == 'B'){
                    if(chs.Count > 0 && chs.Peek() == 'A'){
                        chs.Pop();
                        popped = true;
                    }else{
                        chs.Push(c);
                    }
                }else if(c == 'D'){
                    if(chs.Count > 0 && chs.Peek() == 'C'){
                        chs.Pop();
                        popped = true;
                    }else{
                        chs.Push(c);
                    }
                }else{
                        chs.Push(c);
                }
            }
            str = chs.ToArray();
            if(!popped)
                break;
            Array.Reverse(str);
        }
        return str.Length;
    }
}