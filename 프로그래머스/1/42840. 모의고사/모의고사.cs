using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] answers)
    {
        int[] p1 = { 1, 2, 3, 4, 5 };
        int[] p2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] p3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int[] scores = new int[3];

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == p1[i % p1.Length]) scores[0]++;
            if (answers[i] == p2[i % p2.Length]) scores[1]++;
            if (answers[i] == p3[i % p3.Length]) scores[2]++;
        }

        int maxScore = scores[0];
        if (scores[1] > maxScore) maxScore = scores[1];
        if (scores[2] > maxScore) maxScore = scores[2];

        List<int> resultList = new List<int>();
        if (scores[0] == maxScore) resultList.Add(1);
        if (scores[1] == maxScore) resultList.Add(2);
        if (scores[2] == maxScore) resultList.Add(3);

        return resultList.ToArray();
    }
}