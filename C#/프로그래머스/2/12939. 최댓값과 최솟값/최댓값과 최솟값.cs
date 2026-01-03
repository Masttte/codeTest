using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
        // Linq 사용, ' '로 공백을 나누고 열거자에 저장
        IEnumerable<int> numbers = s.Split(' ').Select(int.Parse);
        int min = numbers.Min();
        int max = numbers.Max();
        return $"{min} {max}";
    }
}