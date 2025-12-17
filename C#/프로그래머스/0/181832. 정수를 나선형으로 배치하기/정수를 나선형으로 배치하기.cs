using System;

public class Solution
{
    public int[,] solution(int n)
    {
        int[,] answer = new int[n, n];

        // 이동 방향 순서 정의: 우(0), 하(1), 좌(2), 상(3)
        int[] dx = { 1, 0, -1, 0 }; //x 숫자가 크면 오른쪽
        int[] dy = { 0, 1, 0, -1 }; //y 숫자가 높으면 아래로

        int x = 0;
        int y = 0;
        int dir = 0; // 방향 정의 (0: 우측으로)

        for (int i = 1; i <= n*n; i++)
        {
            // 숫자 1부터 배열을 돌면서 채우기
            answer[y, x] = i;

            // 다음 이동할 위치 계산
            int nextX = x + dx[dir];
            int nextY = y + dy[dir];

            // 방향을 틀어야 하는 경우:
            // 배열 범위가 높아짐 (오른쪽 벽 부딪힘)
            // 배열 범위가 낮아짐, 왼쪽으로 이동할때 x가 -1이 되어서 인덱스벗어남 (왼쪽벽 부딪힘)
            // 이미 숫자가 채워진 곳 발견 (0이 아닐때)
            if (nextX >= n || nextY >= n || nextX < 0 ||
                answer[nextY, nextX] != 0)
            {

                // 방향 전환 (0 -> 1 -> 2 -> 3 -> 0 ...)
                dir = (dir + 1) % 4;

                // 바꾼 방향으로 이동할 위치 재계산
                nextX = x + dx[dir];
                nextY = y + dy[dir];
            }

            // 좌표 업데이트
            x = nextX;
            y = nextY;
        }

        return answer;
    }
}