using System;

public class Solution
{
    public int[] solution(string[] park, string[] routes)
    {
        int x = park[0].Length;  // x = 스트링 하나의 길이 (가로 길이 w)
        int y = park.Length;     // y = 스트링 전체의 길이 (세로 길이 h)

        //방향정의 - N, S, W, E
        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };

        // 시작 위치 선언
        // int[] startPos = new int[2]; // i 0번: y좌표, 1번 x좌표

        // 시작 위치 선언 튜플로 리펙토링
        (int y, int x) startPos = (0, 0);

        // 스트링 배열을 2차원 char 배열로 변환
        char[,] map = new char[park.Length, park[0].Length];
        for (int y_ = 0; y_ < park.Length; y_++)
        {
            for (int x_ = 0; x_ < park[0].Length; x_++)
            {
                map[y_, x_] = park[y_][x_];

                if (map[y_, x_] == 'S')
                {
                    startPos = (y_, x_); //시작 위치 저장
                }
            }
        }

        // 명령어를 읽기
        foreach (string route in routes)
        {
            // 방향과 값을 가져옴
            char dirSign = route[0];
            int movePower = int.Parse(route[2].ToString());

            int dir = 0;
            // 방향에 따라 dx, dy 인덱스 설정
            if (dirSign == 'N')
            {
                dir = 0;
            }
            else if (dirSign == 'S')
            {
                dir = 1;
            }
            else if (dirSign == 'W')
            {
                dir = 2;
            }
            else if (dirSign == 'E')
            {
                dir = 3;
            }

            // startPos 에서
            int nx = startPos.x;
            int ny = startPos.y;

            bool canMove = true;

            for (int i = 0; i < movePower; i++)
            {
                // 정의된 방향 대로 이동 하면서
                nx += dx[dir];
                ny += dy[dir];

                // 공원을 벗어나는지 확인
                if (nx < 0 || nx >= x || ny < 0 || ny >= y)
                {
                    canMove = false;
                    break;
                }
                // 장애물이 있는지 확인
                // 장애물 위치를 따로 저장했다가 장애물이 한개만 저장된다는 사실에
                // 리스트를 만들려다 그냥 명시적으로 지정하기로함
                if (map[ny, nx] == 'X')
                {
                    canMove = false;
                    break;
                }
            }

            // canMove 확인
            if (!canMove)
            {
                continue; //이동 불가면 무시
            }
            else
            {
                // 이동 가능하면 시작 위치 갱신
                startPos = (ny, nx);
            }
        }

        // 최종위치
        int[] answer = { startPos.y, startPos.x };
        return answer;
    }
}