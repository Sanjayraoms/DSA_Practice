public class Solution {
    public string RemoveOccurrences(string s, string part)
    {
        // var st = new Stack<char>();
        // var patternSize = 0;
        // for (int i = 0; i <= s.Length; i++)
        // {
        //     st.TryPeek(out char ch);
        //     if (ch == part[patternSize])
        //         patternSize++;
        //     else
        //     {
        //         patternSize = 0;
        //         if (ch == part[patternSize])
        //             patternSize++;
        //     }
        //     if (patternSize == part.Length)
        //     {
        //         while (patternSize-- > 0)
        //         {
        //             st.Pop();
        //         }
        //         patternSize = 0;
        //         st.TryPeek(out char c);
        //         if (c == part[patternSize])
        //             patternSize++;
        //     }
        //     if (i > s.Length - 1)
        //         break;
        //     st.Push(s[i]);
        // }
        // var arr = st.ToArray();
        // var sb = new StringBuilder("");
        // for (int i = arr.Length - 1; i >= 0; i--)
        // {
        //     sb.Append(arr[i]);
        // }
        // return sb.ToString();
        int index;
        while ((index = s.IndexOf(part)) != -1) {
            s = s.Remove(index, part.Length);
        }
        
        return s;
    }
}