using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        char[] arr = my_string.ToCharArray();
        for(int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < n; j++){
                answer += arr[i];
            }
        }
        return answer;
    }
}