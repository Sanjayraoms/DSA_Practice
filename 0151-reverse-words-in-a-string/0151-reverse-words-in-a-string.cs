public class Solution {
     public string ReverseWords(string s)
        {
            if(s.Length == 1 && s[0] != ' ')
               return s;
            StringBuilder sb = new StringBuilder("");
            int start = 0;
            int end = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    if(i == 0 && end == 0)
                        end = 1;
                    else if(end == 0)
                        end = i;
                    start = i;
                }
                else if(end != 0)
                {
                    if(sb.Length > 0)
                        sb.Append(' ');
                    sb.Append(s.Substring(start, end - start + 1));
                    end = 0;
                    start = 0;
                }
            }
            if(end != 0)
            {
                sb.Append(' ');
                sb.Append(s.Substring(start, end - start + 1));
            }    
            if(sb[sb.Length-1] == ' ')
               return sb.ToString(0,sb.Length-1);
            if(sb[0] == ' ')
               return sb.ToString(1,sb.Length-1);
            return sb.ToString();
        }
}