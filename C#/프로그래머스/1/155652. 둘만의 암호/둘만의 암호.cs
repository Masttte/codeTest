using System;
using System.Text;

public class Solution {
    public string solution(string s, string skip, int index) {
        
        //스트링빌더 선언
        //String: 한 번 만들어지면 변하지 않는(Immutable)
        //StringBuilder: 내용을 자유롭게 바꿀 수 있는(Mutable)
        //계속 string을 만들면 메모리 효율이 나뻐서 변화가능한 빌더를 씀
        StringBuilder answer = new StringBuilder();

        foreach (char c in s)
        {
            char temp = c; //빌더에 쌓을 문자
            int count = 1; //숫자 카운트

            // index만큼 유효한 이동 반복
            while (count <= index)
            {
                // 1. 한 칸 뒤로 이동
                temp++;
                
                // 2. 'z'를 넘어가면 'a'로 순환
                if (temp > 'z')
                {
                    temp = 'a';
                }

                // 3. skip에 포함된 문자라면 continue
                if (skip.Contains(temp))
                {
                    continue;
                }

                // 유효한 이동이면 카운트 증가
                count++;
            }
            
            //차곡차곡 정리
            answer.Append(temp);
        }
        //스트링 빌더를 다시 .ToString으로 변환
        return answer.ToString();
    }
}