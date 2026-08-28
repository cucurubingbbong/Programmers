using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> hallOfFame = new List<int>(); 

        for (int i = 0; i < score.Length; i++)
        {
            hallOfFame.Add(score[i]);
            
            hallOfFame.Sort();
            
            if (hallOfFame.Count > k)
            {
                hallOfFame.RemoveAt(0);
            }
            answer[i] = hallOfFame[0];
        }
        
        return answer;
    }
}
