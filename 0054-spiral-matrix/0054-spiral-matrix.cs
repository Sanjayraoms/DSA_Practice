public class Solution {
    public IList<int> SpiralOrder(int[][] matrix)
        {
            int top = 0;
            int bottom = matrix.Length - 1;
            int right = matrix[0].Length - 1;
            int left = 0;
            int dir = 0;
            List<int> spiralVal = new List<int>();
            while (top <= bottom && left <= right)
            {
                if (dir == 0)
                {
                    for (int i = left; i <= right; i++)
                        spiralVal.Add(matrix[left][i]);
                    top += 1;
                }
                else if (dir == 1)
                {
                    for (int i = top; i <= bottom; i++)
                        spiralVal.Add(matrix[i][right]);
                    right -= 1;
                }
                else if (dir == 2)
                {
                    for (int i = right; i >= left; i--)
                        spiralVal.Add(matrix[bottom][i]);
                    bottom -= 1;
                }
                else if (dir == 3)
                {
                    for (int i = bottom; i >= top; i--)
                        spiralVal.Add(matrix[i][left]);
                    left += 1;
                }
                dir = (dir + 1) % 4;
            }
            return spiralVal;
        }
}