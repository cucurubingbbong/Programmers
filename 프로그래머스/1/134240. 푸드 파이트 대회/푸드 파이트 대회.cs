using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        
        int[] numArr = new int[food.Length];
        numArr[0] = 1; 

        for(int i = 1; i < numArr.Length; i++)
        {
            numArr[i] = food[i] / 2; 
        }

        string left = "";
        string right = "";

        for (int i = 1; i < numArr.Length; i++)
        {
            for (int j = 0; j < numArr[i]; j++)
            {
                left = left + i; 
                right = i + right;
            }
        }
        answer = left + "0" + right;
        return answer;
    }
}