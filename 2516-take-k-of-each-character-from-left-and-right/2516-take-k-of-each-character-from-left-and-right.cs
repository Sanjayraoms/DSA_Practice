public class Solution {
    public int TakeCharacters(string s, int k)
        {
            if (s.Length < 3 * k)
                return -1;
            int[] freq = new int[3];
            int left = 0, right = s.Length - 1;
            while (left < s.Length && right >= 0 && left <= right)
            {
                if (s[left] == 'a')
                    freq[0]++;
                if (s[left] == 'b')
                    freq[1]++;
                if (s[left] == 'c')
                    freq[2]++;
                if (s[right] == 'a')
                    freq[0]++;
                if (s[right] == 'b')
                    freq[1]++;
                if (s[right] == 'c')
                    freq[2]++;
                if (freq[0] >= k && freq[1] >= k && freq[2] >= k)
                    break;
                left++;
                right--;
            }
            while (left >= 0)
            {
                if (s[left] == 'a')
                {
                    freq[0]--;
                    if (freq[0] < k)
                    {
                        freq[0]++;
                        left++;
                        break;
                    }
                }
                if (s[left] == 'b')
                {
                    freq[1]--;
                    if (freq[1] < k)
                    {
                        freq[1]++;
                        left++;
                        break;
                    }
                }
                if (s[left] == 'c')
                {
                    freq[2]--;
                    if (freq[2] < k)
                    {
                        freq[2]++;
                        left++;
                        break;
                    }
                }
                left--;
            }
            while (right < s.Length)
            {
                if (s[right] == 'a')
                {
                    freq[0]--;
                    if (freq[0] < k)
                    {
                        freq[0]++;
                        right--;
                        break;
                    }
                }
                if (s[right] == 'b')
                {
                    freq[1]--;
                    if (freq[1] < k)
                    {
                        freq[1]++;
                        right--;
                        break;
                    }
                }
                if (s[right] == 'c')
                {
                    freq[2]--;
                    if (freq[2] < k)
                    {
                        freq[2]++;
                        right--;
                        break;
                    }
                }
                right++;
            }
            if (freq[0] >= k && freq[1] >= k && freq[2] >= k)
            {
                return freq[0] + freq[1] + freq[2];
            }
            else
            {
                return -1;
            }
        }
}