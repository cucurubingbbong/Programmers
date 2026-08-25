using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long currentMoney = money; 

        for(int i = 1; i <= count; i++)
        {
            currentMoney -= (long)price * i; 
        }

        return currentMoney > 0 ? 0 : currentMoney * -1;
    }
}