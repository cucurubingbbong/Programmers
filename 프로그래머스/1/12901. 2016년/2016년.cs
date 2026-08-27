public class Solution
{
    public string solution(int a, int b)
    {
        int day = 0;
        for (int i = 1; i < a; i++)
        {
            if (i == 2) day += 29;
            else if (i <= 7) day += (i % 2 == 0) ? 30 : 31;
            else day += (i % 2 == 0) ? 31 : 30;
        }

        day += b-1;

        int last = day % 7;
        string[] days = { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
        return days[last];
    }
}