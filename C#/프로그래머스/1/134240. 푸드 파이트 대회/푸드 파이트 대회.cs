using System;
using System.Text;

public class Solution
{
    public string solution(int[] food)
    {
        // 최적화를 위해 스트링 빌더로 작성
        StringBuilder sb = new StringBuilder();
        int LogicNum;

        // 인덱스 1 번부터  
        for (int i = 1; i < food.Length; i++)
        {
            // 두명에게 공평하게 줄 푸드 나눠서
            LogicNum = food[i] / 2;

            for (int j = 1; j <= LogicNum; j++)
            {   // 인덱스 번호를 반복해서 담고 
                sb.Append(i); 
            }
            
        }

        // 꺼꾸로 돌리기 위해 정리
        string answer = sb.ToString();
        char[] temp = answer.ToCharArray();
        Array.Reverse(temp);
        string answerReverse = new string(temp);

        return answer + "0" + answerReverse;
    }
}