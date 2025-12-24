public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        
        if (a == b)
        {
            return a;
        }
        else if (a > b)
        {
            int temp = a - b;
            for (int i = 0 ; i <= temp ; i++ )
            {
                answer += b + i;
            }
            return answer;
        }
        else
        {
            int temp = b - a;
            for (int i = 0 ; i <= temp ; i++ )
            {
                answer += a + i;
            }
            return answer;
        }
    }
}
