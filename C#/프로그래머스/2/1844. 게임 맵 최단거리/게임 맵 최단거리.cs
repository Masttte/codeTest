using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] maps) {
        int y = maps.GetLength(0);  // m
        int x = maps.GetLength(1);  // n
        
        // 방향 벡터: 상, 하, 좌, 우
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };
        
        // 방문 여부 및 거리를 저장할 배열
        int[,] distance = new int[y, x];
        
        // BFS를 위한 Queue
        Queue<(int y, int x)> queue = new Queue<(int y, int x)>();
        
        // 시작점 설정
        queue.Enqueue((0, 0));
        distance[0, 0] = 1;
        
        // 탐색
        while (queue.Count > 0) {
            (int y, int x) current = queue.Dequeue();
            
            // 상하좌우의 다음 위치 체크
            for (int i = 0; i < 4; i++) {
                int nx = current.x + dx[i];
                int ny = current.y + dy[i];
                
                // 맵 범위 체크
                if (ny < 0 || ny >= y || nx < 0 || nx >= x) {
                    continue;
                }
                
                // 거리 정보가 존재하거나, 벽인 곳
                if (distance[ny, nx] != 0 || maps[ny, nx] == 0) {
                    continue;
                }
                
                // 이동 가능하면 카운트하고 큐에 넣기 (여러 경로를 저장할수 있음)
                distance[ny, nx] = distance[current.y, current.x] + 1;
                queue.Enqueue((ny, nx));
            }
        }
        
        // 목적지의 거리 반환
        int answer = distance[y - 1, x - 1];
        
        // 전부 막혀있어서 값을 받지 못하면 -1
        return answer == 0 ? -1 : answer;
    }
}
