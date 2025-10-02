public class Solution {
    public int MaxBottlesDrunk(int numBottles, int numExchange) {
        int bottles = numBottles;
        int empty = numBottles;
        numBottles = 0;
        while((empty+numBottles) >= numExchange){
            if(empty >= numExchange){
                empty -= numExchange;
                numBottles++;
                numExchange++;
            }else{
                empty += numBottles;
                bottles += numBottles;
                numBottles = 0;
            }
        }
        return bottles + numBottles;
    }
}