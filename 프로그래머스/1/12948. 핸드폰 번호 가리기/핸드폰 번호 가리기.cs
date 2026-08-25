using System;

public class Solution {
    public string solution(string phone_number) {
        char[] arr = phone_number.ToCharArray(); 
        
        for (int i = 0; i < arr.Length - 4; i++)
        {
            arr[i] = '*'; 
        }
        
        return new string(arr);
    }
}