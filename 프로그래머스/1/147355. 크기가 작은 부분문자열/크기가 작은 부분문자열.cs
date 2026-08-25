using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        char[] c = t.ToCharArray();
        long num = long.Parse(p);
        for(int i = 0; i <= t.Length - p.Length; i++)
        {
            string checknum = "";
            for(int j = 0; j < p.Length; j++)
            {
                checknum += (char)c[i+j];
            }
            if(num >= long.Parse(checknum)) answer++;
        }
        return answer;
    }
}