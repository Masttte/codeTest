using System;

public class Solution {
    public int solution(int n) {
        int temp = n;
        while(n%6!=0) //n이 6으로 나누어 떨어질 떄 까지
        {
            n += temp; //n과 동일한값(temp)를 계속 더함으로써 곱셈효과를 낸다
        }
        return n/6; // 최소 공배수를 피자한판의 조각수로 나누고 마무리
    }
}
