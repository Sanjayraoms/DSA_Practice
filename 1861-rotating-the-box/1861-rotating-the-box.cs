public class Solution {
    public char[][] RotateTheBox(char[][] box) {
        int m = box.Length;
        int n = box[0].Length;
        char[][] res = new char[n][];
        for (int i = 0; i < n; i++)
        {
            res[i] = new char[m];
        }
        foreach (char[] arr in box)
        {
            var spacePointr = arr.Length - 1;
            var stonePointr = spacePointr - 1;
            while (spacePointr >= 0 && stonePointr >= 0)
            {
                if (arr[spacePointr] == '.' && arr[stonePointr] == '#')
                {
                    (arr[spacePointr], arr[stonePointr]) = (arr[stonePointr], arr[spacePointr]);
                    spacePointr--;
                    stonePointr--;
                }
                else if (arr[stonePointr] == '*')
                {
                    spacePointr = stonePointr - 1;
                    stonePointr -= 2;
                }
                else if (arr[stonePointr] == '.' && arr[spacePointr] == '.')
                {
                    stonePointr--;
                }
                else if (arr[spacePointr] == '#' && arr[stonePointr] == '#')
                {
                    stonePointr -= 2;
                    spacePointr -= 2;
                }
                else
                {
                    spacePointr--;
                    stonePointr--;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            var temp = 0;
            for (int j = m - 1; j >= 0; j--)
            {
                res[i][temp] = box[j][i];
                temp++;
            }
        }
        return res;
    }
}