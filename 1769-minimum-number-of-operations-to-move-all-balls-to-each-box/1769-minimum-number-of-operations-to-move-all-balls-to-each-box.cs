public class Solution {
    public int[] MinOperations(string boxes) {
        int len = boxes.Length;
        int[] res = new int[len];
        int ballsToLeft = 0, movesToLeft = 0, ballsToRight = 0, movesToRight = 0;

        for(int i = 0; i < len; i++){
            res[i] += movesToLeft;
            ballsToLeft += Convert.ToInt16(boxes[i]) - '0';
            movesToLeft += ballsToLeft;

            var j = len - 1 - i;
            res[j] += movesToRight;
            ballsToRight += Convert.ToInt16(boxes[j]) - '0';
            movesToRight += ballsToRight;
        }
        return res;
    }
}