using System;

public class Solution
{
    public bool solution(string s)
    {
        // 첫 스트링이 ) 인경우
        // 끝 스트링이 ( 인 경우
        if (s[0] == ')' || s[s.Length - 1] == '(')
        {
            return false;
        }

        // '('의 개수와 ')'의 개수가 동일하지 않은경우
        if (s.Split('(').Length != s.Split(')').Length)
        {
            return false;
        }

        // s 를 순회하면서 '('의 개수보다 ')'가 많아지는 순간
        int open = 0;
        int close = 0;
        foreach (char symbol in s)
        {
            if (symbol == '(')
                open++;

            if (symbol == ')')
                close++;

            if (close > open)
                return false;
        }

        return true;
    }
}