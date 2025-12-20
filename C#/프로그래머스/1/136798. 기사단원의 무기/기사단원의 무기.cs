using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int divisorCount;

        // 1번 기사부터 number번 기사까지 반복
        for (int i = 1; i <= number; i++) 
        {
            divisorCount = 0;
            //// 약수 찾기 (일반적인 방법)
            //// 12의 약수를 찾는다면
            //for (int j = 1; j <= 12; j++)  // 12번 반복
            //{
            //    if (12 % j == 0)
            //        약수발견! 
            //}
            
            //// 약수 찾기 (빠른 방법)
            //// 제곱근(√루트) 활용 √12 = 3.46 → 3번 반복
            // 곱해서 기사 index가 되는 제곱근 까지 반복
            for (int j = 1; j * j <= i; j++) 
            {
                if (i % j == 0) 
                {
                    divisorCount++; // j는 약수임
                    
                    // j와 짝이 되는 약수도 카운트 (4의 경우 '1의 짝은 4', '2의 짝은 2')
                    //단, j가 제곱근인 경우 중복 방지 (4의 경우 '2의 짝 2'는 중복)
                    if (j * j < i) 
                    {
                        divisorCount++;
                    }
                }
            }

            // 제한수치(limit) 초과 여부 확인 및 철의 무게 더하기
            if (divisorCount > limit) 
            {
                // 제한수치를 초과하면 협약된 공격력(power)을 더함
                answer += power;
            } 
            else 
            {
                // 초과하지 않으면 약수의 개수(공격력) 그대로 더함
                answer += divisorCount;
            }
        }

        return answer;
    }
}