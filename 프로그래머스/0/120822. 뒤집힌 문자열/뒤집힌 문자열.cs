using System;

public class Solution {
    public string solution(string my_string) {
        char[] charArr = my_string.ToCharArray();
        Array.Reverse(charArr);
        string answer = new string(charArr);
        return answer;
    }
}