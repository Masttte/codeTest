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
        // k 가 0이된 순간 멈춤

        // List로 했다가 시간초과남
        // Dictionary로 리펙토링

        // Dictionary Key(귤 숫자)와 Value(개수)
        Dictionary<int, int> tangerine_D = new Dictionary<int, int>();

        // tangerine 배열을 순회
        foreach (int number in tangerine)
        {
            // 숫자 Key가 딕셔너리에 존재하면
            if (tangerine_D.ContainsKey(number))
            {
                tangerine_D[number]++;// 그 숫자 Key에 해당하는 딕셔너리 값(Value) 1 증가
            }
            else
            {   // 그 숫자 Key가 없으면 값 생성
                tangerine_D[number] = 1;
            }
        }
        // 예시: tangerine = [1, 3, 2, 5, 4, 5, 2, 3]
        // 결과: tangerine_D = { 1:1, 3:2, 2:2, 5:2, 4:1 }

        // Value 기준으로 내림차순 리스트 생성
        List<int> desendingList = tangerine_D.Values.OrderByDescending(x => x).ToList();

        // Value 만큼 k에서 꺼낼때 마다 answer++ 
        foreach (int value in desendingList)
        {
            k -= value;
            answer++;

            // k개 만큼 다 꺼냈으면 멈춤
            if (k <= 0)
            {
                break;
            }
        }

        return answer; //완료
    }
}
