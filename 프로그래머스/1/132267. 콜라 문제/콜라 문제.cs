using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;

        while (n >= a)
        {
            int newCola = (n / a) * b;  
            int restBottles = n % a;    

            answer += newCola;  
            n = newCola + restBottles;
        }
        
        return answer;
    }
}