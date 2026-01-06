using System;

public class Solution
{
    public bool solution(string s)
    {
        int count = 0;

        foreach (char c in s)
        {
            if (c == '(')
            {
                count++;
            }
            else
            {
                if (count == 0)
                    return false;

                count--;
            }
        }

        return count == 0;
    }
}