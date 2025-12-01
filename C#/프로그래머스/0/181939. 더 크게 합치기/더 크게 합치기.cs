using System;

public class Solution {
    public int solution(int a, int b) 
    {
        int aNum = int.Parse($"{a}{b}"); // 스트링 지정없이 이렇게 하면 됨
        int bNum = int.Parse($"{b}{a}");
        return Math.Max(aNum, bNum); //Math.Max 는 더 큰값 반환, 같으면 앞의거 반환
    }
}