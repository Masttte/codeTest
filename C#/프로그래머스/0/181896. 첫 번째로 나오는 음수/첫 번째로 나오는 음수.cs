using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int answer = Array.FindIndex(num_list, x => x < 0);
        return answer;
    }
}