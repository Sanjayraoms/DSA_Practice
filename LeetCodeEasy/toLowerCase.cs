// Given a string s, return the string after replacing every uppercase letter with the same lowercase letter
// Example 1:
//    Input: s = "Hello"
//    Output: "hello"
// Example 2:
//    Input: s = "here"
//    Output: "here"
// Example 3:
//    Input: s = "LOVELY"
//    Output: "lovely"

public class Solution {
    public string ToLowerCase(string s) {
        char[] allChars = s.ToCharArray();
        int asciiVal = 0;
        int diffromStart = 0;
        for(int i = 0; i < allChars.Length ; i++){
            asciiVal = (int)allChars[i];
            if(asciiVal <= 90 && asciiVal >= 65){
                diffromStart = asciiVal - 65;
                asciiVal = 97 + diffromStart;
                allChars[i] = (char)asciiVal;
            }
        }
        return new string(allChars);
    }
}