using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        // 리스트 배열 생성
        List<int> list = new List<int>();

        // 가장뒤(i = 배열.Length - 1)를 List<>에 추가하고 -1을 대입
        list.Add(numbers[numbers.Length - 1]);
        numbers[numbers.Length - 1] = -1;

        // 배열을 역순으로 순회 할 예정 (가장뒤는 이미 함 -1)
        for (int i = numbers.Length - 2; i >= 0; i--)
        {
            for (int j = list.Count - 1; j >= 0; j--)
            {
                // 리스트 보다 자신이 작으면
                if (numbers[i] < list[j])
                {
                    list.Add(numbers[i]);
                    numbers[i] = list[j];
                    break;
                }
                else
                {// 아니면 지워서 최적화
                    list.Remove(list[j]);
                }

                // 내가 제일 크면
                if (j == 0)
                {
                    list.Add(numbers[i]);
                    numbers[i] = -1; // -1을 대입
                }
            }
        }

        return numbers; //완료! 스텍으로 리펙토링 할 예정
    }
}