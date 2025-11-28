using System;

// 최대공약수와 최소공배수를 구하는 코드 연습
public class Solution {
    // 1. 유클리드 호제법을 이용한 최대공약수(GCD) 함수
    private int GCD(int a, int b) {
        // 참고: a와 b 중 작은 수가 b가 되도록 정렬하지 않아도, 첫 번째 루프에서 자동으로 처리
        while (b != 0) {
            int remain = a % b;
            a = b;
            b = remain;
        }
        return a;
    }

    // 2. 최소공배수(LCM) 함수
    // LCM(a, b) = (a * b) / GCD(a, b) 공식을 사용합니다.
    private int LCM(int a, int b) {
        return (a * b) / GCD(a, b);
    }

    // 3. 문제 해결 함수
    public int solution(int n) {
        // n과 6의 최소공배수를 구합니다.
        int leastCommonMultiple = LCM(n, 6);
        
        // 최소공배수를 6(피자 한 판의 조각 수)으로 나누어 필요한 최소 피자 판 수를 구합니다.
        int answer = (leastCommonMultiple / 6);
        
        return answer;
    }
}
