using System.Collections;
using System.Collections.Generic;

public class Solution
{
        // BFS를 위한 Queue
        Queue<(int y, int x)> queue = new Queue<(int y, int x)>();
        // 각종 위치 지정
        (int y, int x) startPos = (0, 0);      // S
        (int y, int x) endPos = (0, 0);        // E
        (int y, int x) leverPos = (0, 0);      // L
        (int y, int x) currentPos = (0, 0);    // 현재 위치

        // 방향 벡터 상, 하, 좌, 우
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };

    public int solution(string[] maps)
    {
        // 스트링 배열을 2차원 char 배열로 변환
        char[,] mapGrid = new char[maps.Length, maps[0].Length];
        for (int i = 0; i < maps.Length; i++)
        {
            for (int j = 0; j < maps[0].Length; j++)
            {
                if (maps[i][j] == 'S')
                {
                    startPos = (i, j);
                }
                else if (maps[i][j] == 'L')
                {
                    leverPos = (i, j);
                }
                else if (maps[i][j] == 'E')
                {
                    endPos = (i, j);
                }
            }
        }

        // 시작점에서 레버까지의 시간
        int timeToLever = BFS(startPos, leverPos, maps);
        if (timeToLever == -1)
        {
            return -1;
        }

        // 레버에서 출구까지의 시간
        int timeToEnd = BFS(leverPos, endPos, maps);

        return timeToEnd == -1 ? -1 : timeToLever + timeToEnd;
    }

    public int BFS((int y, int x) startPos, (int y, int x) endPos, string[] maps)
    {
        int y = maps.Length;     // y = 스트링 전체의 길이
        int x = maps[0].Length;  // x = 스트링 하나의 길이
        // 방문 여부 및 거리를 저장할 2차원 배열
        int[,] distance = new int[y, x];

        // 시작점 설정
        queue.Enqueue(startPos);
        distance[startPos.y, startPos.x] = 0; // 최종목표로 시간을 반환할거라 0base

        // 탐색
        while (queue.Count > 0)
        {
            currentPos = queue.Dequeue();

            // 상하좌우의 다음 위치 체크
            for (int i = 0; i < 4; i++)
            {
                int nx = currentPos.x + dx[i];
                int ny = currentPos.y + dy[i];

                // 맵 범위 체크
                if (ny < 0 || ny >= y || nx < 0 || nx >= x)
                {
                    continue;
                }

                // 거리 정보가 존재하거나, 벽인 곳
                if (distance[ny, nx] != 0 || maps[ny][nx] == 'X')
                {
                    continue;
                }

                // 이동 가능하면 카운트하고 큐에 넣기 (여러 경로를 저장할수 있음)
                distance[ny, nx] = distance[currentPos.y, currentPos.x] + 1;
                queue.Enqueue((ny, nx));

                // 도착지에 도달하면 종료
                if (ny == endPos.y && nx == endPos.x)
                {
                    queue.Clear();
                    return distance[ny, nx];
                }
            }
        }

        // 막혀있어서 값을 받지 못하면 -1
        return -1;
    }
}