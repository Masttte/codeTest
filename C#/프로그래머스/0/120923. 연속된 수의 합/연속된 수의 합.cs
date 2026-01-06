using System;

public class Solution
{
    public int[] solution(int num, int total)
    {
        int[] answer = new int[num];

        // total을 num으로 나눈 몫을 구한다
        int quotient = total / num;

        // num 이 홀수인 경우
        if (num % 2 == 1)
        {
            // 홀수인 경우 num을 2로 나눈 몫이 배열의 중앙인덱스
            int centerIndex = num / 2;
            // 중앙 인덱스에서 중앙 인덱스 만큼을 빼면 시작 숫자
            int startNumber = quotient - centerIndex;
            // 시작 숫자를 1씩 증가하며 정렬
            for (int i = 0; i < num; i++)
            {
                answer[i] = startNumber + i;
            }
        }
        else // num 이 짝수인 경우
        {
            // 짝수인 경우 중앙 오른쪽을 중앙인덱스로 함
            int centerIndex = num / 2;
            // 중앙 인덱스에서 중앙 인덱스 +1 만큼을 빼면 시작 숫자
            int startNumber = quotient - centerIndex + 1;
            // 시작 숫자를 1씩 증가하며 정렬
            for (int i = 0; i < num; i++)
            {
                answer[i] = startNumber + i;
            }
        }

        return answer;
    }
}