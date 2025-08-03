public class Solution {
    public IList<string> FizzBuzz(int n) {
        var res = new List<string>();
        for(int i = 1; i <= n; i++){
            var resStr = "";
            if(i % 3 == 0)
                resStr = "Fizz";
            if(i % 5 == 0)
                resStr = string.Concat(resStr,"Buzz");
            resStr = resStr == "" ? i.ToString() : resStr;
            res.Add(resStr);
        }
        return res;
    }
}