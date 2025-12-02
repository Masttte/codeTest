using System.Linq; // Min()과 Where()를 사용하기 위해 필요합니다.

public class Solution {
    public int[] solution(int[] arr) {
        if (arr.Length <= 1) {
            return new int[] { -1 };
        }

        // 배열 순서 안바꾸고 최소값 확인
        int minVal = arr.Min();
        
        // 최솟값과 같지 않은 원소만 필터링하여 새 배열 만들기
        // Where(x => x != minVal) 라는 람다식을 사용해서 표현
        int[] answer = arr.Where(x => x != minVal).ToArray();
        
        return answer;
    }
}