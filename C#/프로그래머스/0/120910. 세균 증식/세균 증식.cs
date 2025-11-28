using System;

public class Solution {
    public int solution(int n, int t)
{
    double step = Math.Pow(2, t); //거듭 제곱 (2^t)
    int answer = n * (int)step;
    return answer;
}
}
