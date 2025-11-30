using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[n];
        for (int i = 0; i < n; i++)
        {
            answer[i] = num_list[i];
        }
        return answer;
    }
}


//다른 답
public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[] {};
        answer = num_list.Take(n).ToArray();
        return answer;
    }
}
