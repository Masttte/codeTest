using System;

public class Solution {
    public int solution(int a, int b) 
    {
        int ab = int.Parse($"{a}{b}"); // 스트링 지정없이 이렇게 하면 됨
        int ba = int.Parse($"{b}{a}");
        return Math.Max(ab, ba); //Math.Max 는 더 큰값 반환, 같으면 앞에꺼 반환
    }
}
