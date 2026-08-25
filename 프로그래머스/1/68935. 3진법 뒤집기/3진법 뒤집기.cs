using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        string ternary = "";

        while (n > 0)
        {
            ternary += (char)(n % 3 + '0');
            n /= 3;
        }

        long mul = 1; 
        for (int i = ternary.Length - 1; i >= 0; i--)
        {
            answer += (ternary[i] - '0') * (int)mul;
            mul *= 3;
        }
        return answer;
    }
}