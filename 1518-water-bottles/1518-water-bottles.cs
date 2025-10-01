public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int totBottles = 0;
        while(numBottles >= numExchange){
            int k = numBottles / numExchange;
            totBottles += numExchange * k;
            numBottles -= numExchange * k;

            numBottles += k;
        }
        return totBottles + numBottles;
    }
}