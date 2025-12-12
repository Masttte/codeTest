using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal)
    {
        //골 매개변수의 첫 문자열과 두 카드의 문자열에서 같은게 있나 확인
        // 없으면 NO
        // 있으면 해당 카드를 사용하고 골 두번째 문자열 로 이동하고 반복
        for (int i = 0; i < goal.Length; i++)
        {
            // out if index 방지를 위해 배열 길이가 0이면 무시 (이걸 먼저 체크)
            if (!(cards1.Length == 0) && goal[i] == cards1[0])
            { //cards1[0] 의 데이터를 지우고 앞으로 당긴다.
                string[] temp = new string[cards1.Length - 1];
                Array.Copy(cards1, 1, temp, 0, cards1.Length - 1); // cards1의 1번째 인덱스부터 temp에 복사
                cards1 = temp;
                
            }
            else if (!(cards2.Length == 0) && goal[i] == cards2[0])
            { //cards2[0] 의 데이터를 지우고 앞으로 당긴다.
                string[] temp = new string[cards2.Length - 1];
                Array.Copy(cards2, 1, temp, 0, cards2.Length - 1);
                cards2 = temp;
            }
            else
            {
                return "No";
            }
        }

        return "Yes";
    }
}