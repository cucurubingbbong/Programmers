using System;

public class Solution
{
    public int solution(int[] d, int budget)
    {
        int answer = 0;

        for (int i = 0; i < d.Length - 1; i++)
        {
            for (int j = 0; j < d.Length - 1 - i; j++)
            {
                if (d[j] > d[j + 1])
                {
                    int temp = d[j];
                    d[j] = d[j + 1];
                    d[j + 1] = temp;
                }
            }
        }

        int sum = 0;
        for (int i = 0; i < d.Length; i++)
        {
            sum += d[i];
            if (sum <= budget)
            {
                answer++;
            }
            else
            {
                break;
            }
        }

        return answer;
    }
}