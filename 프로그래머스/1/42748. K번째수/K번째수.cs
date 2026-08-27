using System;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int length = commands[i, 1] - commands[i, 0] + 1;

            answer[i] = GetSliceInt(array, new int[length], commands[i, 0], commands[i, 1], commands[i, 2]);
        }
        return answer;
    }

    public int GetSliceInt(int[] array, int[] slice, int start, int end, int k)
    {
        for (int i = 0; i < slice.Length; i++)
        {
            slice[i] = array[start - 1 + i];
        }
        Array.Sort(slice);
        return slice[k - 1];
    }

}