public static int solution(int n, int w, int num)
{

    int count = 0;
    while (num <= n)
    {
        //꺼내기 카운트
        count++;
        //다음위치 계산        
        if (num % w == 0)
        {
            num++;
        }
        else
        {
            num += (((((num / w) + 1) * w) - num) * 2) + 1; // 이 식으로 넘버에 값을 더하는데 연구필요
        }
    }
    return count;
}
