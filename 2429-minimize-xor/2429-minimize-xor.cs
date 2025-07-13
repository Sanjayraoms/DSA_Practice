public class Solution {
    public int MinimizeXor(int num1, int num2) {
        int cnt1 = count_bits(num1);
        int cnt2 = count_bits(num2);

        int res = num1;
        int i = 0;
        while(cnt1 > cnt2){
            if((res & (1 << i)) > 0){
                res = res ^ (1 << i);
                cnt1-=1;
            }
            i++;
        }

        while(cnt1 < cnt2){
            if((res & (1 << i)) == 0){
                res = res | (1 << i);
                cnt1+=1;
            }
            i++;
        }

        return res;
    }
    private int count_bits(int num){
        int res = 0;
        while(num > 0){
            res += num & 1;
            num = num >> 1;
        }
        return res;
    }
}