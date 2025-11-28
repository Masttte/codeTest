using System;

public class Solution {
    public int solution(int n, int t)
{
    var step = Math.Pow(2, t);
    int answer = n * (int)step;
    return answer;
}
}