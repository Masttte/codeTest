using System;

public class Solution
{
    public int solution(string dirs)
    {
        // 11 x 11 그리드 맵에 점-base 움직임
        int[,] map = new int[11, 11];
        // 시작 좌표
        int x = 5;
        int y = 5;

        // x위치로 10 x 11 의 방문 길이가 있고
        // y위치로 11 x 10 의 방문 길이가 있다
        bool[,] x_visited = new bool[10, 11];
        bool[,] y_visited = new bool[11, 10];

        //방향정의 - U, D, L, R
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { 1, -1, 0, 0 };

        // dirs 명령어를 읽기
        foreach (char dirSign in dirs)
        {
            int dir = 0;
            // 방향에 따라 dx, dy 인덱스 설정
            if (dirSign == 'U')
            {
                dir = 0;
            }
            else if (dirSign == 'D')
            {
                dir = 1;
            }
            else if (dirSign == 'L')
            {
                dir = 2;
            }
            else if (dirSign == 'R')
            {
                dir = 3;
            }

            // 다음 위치 설정
            int nx = x + dx[dir];
            int ny = y + dy[dir];

            // 범위 체크
            if (nx < 0 || nx > 10 || ny < 0 || ny > 10)
            {
                continue;
            }

            // 방문 체크
            if (dir == 0) // U
            {
                y_visited[x, y] = true;
            }
            else if (dir == 1) // D
            {
                y_visited[x, ny] = true;
            }
            else if (dir == 2) // L
            {
                x_visited[nx, y] = true;
            }
            else if (dir == 3) // R
            {
                x_visited[x, y] = true;
            }

            // 위치 이동
            x = nx;
            y = ny;
        }

        // true 로 변한 방문길이 카운트
        int answer = 0;

        foreach (bool visited in x_visited)
        {
            if (visited)
                answer++;
        }
        foreach (bool visited in y_visited)
        {
            if (visited)
                answer++;
        }

        return answer; // 생각할게 의외로 많은 문제였다
    }
}