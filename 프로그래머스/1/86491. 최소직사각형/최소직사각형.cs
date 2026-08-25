using System;
public class Solution
{
    public int solution(int[,] sizes)
    {
        int answer = 0;
        int minWidth = 0;
        int minHeight = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int w = sizes[i, 0];
            int h = sizes[i, 1];

            int currentMax = (w > h) ? w : h;
            int currentMin = (w > h) ? h : w; 

            minWidth = (currentMax > minWidth) ? currentMax : minWidth;
            minHeight = (currentMin > minHeight) ? currentMin : minHeight;
        }

        answer = minWidth * minHeight;
        return answer;
    }
}