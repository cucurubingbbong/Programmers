public class Solution
{
    public long solution(long n)
    {
        long[] counts = new long[10];

        while (n > 0)
        {
            counts[n % 10]++;
            n /= 10;
        }

        long result = 0;
        for (int i = 9; i >= 0; i--)
        {
            while (counts[i] > 0)
            {
                result = result * 10 + i;
                counts[i]--;
            }
        }

        return result;
    }
}