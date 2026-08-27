using System;
using System.Collections.Generic; 

public class Solution
{
    public int[] solution(int[] numbers)
    {
        List<int> nums = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                nums.Add(numbers[i] + numbers[j]);
            }
        }

        nums.Sort();

        List<int> resultList = new List<int>();
        for (int i = 0; i < nums.Count; i++)
        {
            if (i == 0 || nums[i] != nums[i - 1])
            {
                resultList.Add(nums[i]);
            }
        }

        return resultList.ToArray();
    }
}