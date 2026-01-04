using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        int answer = 0;

        // 귤을 담을 상자 배열 tangerine 이 있다
        // 거기서 꺼낼 귤 k개 가 있다
        // tangerine에서 귤 k개 만큼 가져오는데
        // 최대한 숫자가 같은 귤을 꺼내고 (서로 다른 종류의 수를 최소화)
        // 숫자가 다른 종류의 수 만큼 return answer

        // 의사코드
        // 배열을 순회하면서
        // 숫자별로 자신과 같은 숫자의 개수 n 목록 파악
        // 가장 높은 n들 부터 차례로 k - n 실행할때 마다 answer++ 추가하는데
        // k 가 0 이하된 순간 멈춤

        // 같은 귤 개수 정렬
        List<int> sameTangerine = new List<int>();

        // 이미 계산한 숫자 정렬
        List<int> checkedNumber = new List<int>();

        for (int i = 0; i < tangerine.Length; i++)
        {
            // 현재 귤의 숫자
            int number = tangerine[i];

            // 이미 체크한 숫자면 패스
            if (checkedNumber.Contains(number))
            {
                continue;
            }

            // 같은 숫자의 귤 개수 파악
            int count = tangerine.Count(x => x == number);
            sameTangerine.Add(count);

            checkedNumber.Add(number);
        }

        while (k > 0)
        {
            // 가장 큰 같은 귤 개수 파악
            int max = sameTangerine.Max();
            sameTangerine.Remove(max);
            
            // k 에서 해당 개수만큼 빼기
            k -= max;
            
            // 종류 수 추가
            answer++;
        }

        return answer;
    }
}
