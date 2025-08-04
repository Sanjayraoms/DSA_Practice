public class Solution {
    public string AddStrings(string num1, string num2) {
        StringBuilder sb = new();
        int l1 = num1.Length-1;
        int l2 = num2.Length-1;
        int carry = 0;
        while(l1 >= 0 && l2 >= 0)
        {
            int sum = num1[l1] - '0' + num2[l2] - '0';
            sum += carry;
            carry = sum/10;
            int rem = sum%10;
            sb.Insert(0, rem.ToString());
            l1--;
            l2--;
        }
        while(l1 >= 0)
        {
            int sum = num1[l1] - '0';
            sum += carry;
            carry = sum/10;
            int rem = sum%10;
            sb.Insert(0, rem.ToString());
            l1--;
        }
        while(l2 >= 0)
        {
            int sum = num2[l2] - '0';
            sum += carry;
            carry = sum/10;
            int rem = sum%10;
            sb.Insert(0, rem.ToString());
            l2--;
        }
        if(carry > 0)
            sb.Insert(0, carry.ToString());

        return sb.ToString();
    }
}