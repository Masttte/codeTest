using System;
using System.Linq;

public class Solution {
    public int[] solution(int num, int total) {
                // 연속된수의 합
        int[] answer = new int[] { };

        // total을 num으로 나눈 몫과 나머지를 구한다
        int quotient = total / num;
        int remainder = total % num;

        // num의 순서 배열을 담을 배열
        int[] sort = new int[num];

        // num 이 짝수인경우와 홀수인 경우로 나눔
        if (num % 2 == 1)
        {
            // 홀수인 경우 num을 2로 나눈 몫이 배열의 중앙인덱스
            int centerIndex = num / 2;
            // 중앙 인덱스에서 중앙 인덱스 만큼을 빼면 시작 숫자
            int startNumber = quotient - centerIndex;
            // 시작 숫자를 1씩 증가하며 정렬
            for (int i = 0; i < num; i++)
            {
                sort[i] = startNumber + i;
            }
        }
        else
        {
            // 짝수인 경우
            int centerIndex = num / 2;
            // 중앙 인덱스에서 중앙 인덱스 + 1 만큼을 빼면 시작 숫자
            int startNumber = quotient - centerIndex + 1;
            // 시작 숫자를 1씩 증가하며 정렬
            for (int i = 0; i < num; i++)
            {
                sort[i] = startNumber + i;
            }
        }

        return sort;
    }
}