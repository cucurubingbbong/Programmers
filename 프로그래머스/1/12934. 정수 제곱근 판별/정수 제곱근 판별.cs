public class Solution
{
    public long solution(long n)
    {
        long left = 1;
        long right = 7071068;

        while (left <= right)
        {
            long mid = (left + right) / 2;
            long square = mid * mid;
            if (square == n)
            {
                return (mid + 1) * (mid + 1);
            }
            else if (square < n)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}