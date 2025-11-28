using System;

public class Solution {
    public int solution(int n, int t)
{
    double step = Math.Pow(2, t); //거듭 제곱 (2^t)
    int answer = n * (int)step;
    return answer;
}
}

//다른 풀이들
public class Solution {
    public int solution(int n, int t) {
        int answer = n;
        for(int i =0; i<t; i++){
            answer = answer *2;
        }
        return answer;
    }
}

// 컴퓨터 프로그래밍에서 비트를 왼쪽으로 이동시키는 것은 2배를 곱한것과 같다
// 따라서 t번 왼쪽으로 이동시키면 거듭제곱의 원리가 적용된다!
public class Solution {
    public int solution(int n, int t) {
        int answer = n << t; //비트 연산자 t번 만큼 이동
        return answer;
    }
}
