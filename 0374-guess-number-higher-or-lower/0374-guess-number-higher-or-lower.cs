/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int low = 1;
        int high = n;

        while(low <= high){
            var mid = low + (high-low)/2;
            var num = guess(mid);
            if(num == 0)
                return mid;
            else if(num == -1)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return -1;
    }
}