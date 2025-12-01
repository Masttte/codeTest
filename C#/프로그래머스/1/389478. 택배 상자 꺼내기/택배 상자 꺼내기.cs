using System;

public class Solution {
    public int solution(int n, int w, int num) {
        
        int answer = 0;
        
        // 1. num의 현재 층(row)과 가로 위치(col) 구하기 (0-based index)
        int targetRow = (num - 1) / w;
        int targetCol = (num - 1) % w;
        
        // 홀수 층(1, 3...)인 경우 역순이므로 col 위치를 보정해줘야 함
        // 예: w=6일 때, 짝수층의 0번 인덱스는 홀수층의 5번 인덱스와 같은 수직선상에 있음
        if (targetRow % 2 == 1) {
            targetCol = w - 1 - targetCol;
        }
        
        // 2. 현재 층부터 위로 올라가면서 상자가 있는지 확인
        for (int row = targetRow; row <= (n - 1)/w ; row++) {
            int boxNum;
            
            // 해당 층(row)에서 targetCol 위치에 있는 상자 번호 계산
            if (row % 2 == 0) {
                // 짝수 층: 왼쪽 -> 오른쪽 (0, 1, 2...)
                boxNum = row * w + targetCol + 1;
            } else {
                // 홀수 층: 오른쪽 -> 왼쪽 (w-1, w-2, ... 0)
                boxNum = row * w + (w - 1 - targetCol) + 1;
            }
            
            // 3. 상자 번호가 n 이하인 경우에만 카운트
            if (boxNum <= n) {
                answer++;
            }
        }
        
        return answer;
    }
}
