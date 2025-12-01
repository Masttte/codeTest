using System;

public class Solution {
    public int solution(int a, int b) {
        string ab = $"{a}{b}";
        string ba = $"{b}{a}";
        int abP = int.Parse(ab);
        int baP = int.Parse(ba);

        if (abP >= baP)
        {
           return abP;
        }
        else { return baP; }
    }
}