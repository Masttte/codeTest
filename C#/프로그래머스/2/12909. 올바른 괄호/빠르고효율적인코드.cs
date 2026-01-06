using System;

public class Solution
{
    public bool solution(string s)
    {
        int count = 0;

        foreach (char c in s)
        {
            if (c == '(') // '(' 와 ')'의 짝짝이를 맞춰서 뱉는 효율적인 코드
            {
                count++; // '('++
            }
            else
            {
                if (count == 0)
                    return false;

                count--; // +된 '('와 짝 맞추기 
            }
        }

        return count == 0; // 짝이 맞춰지면 ture 아니면 자동으로 false
    }
}
