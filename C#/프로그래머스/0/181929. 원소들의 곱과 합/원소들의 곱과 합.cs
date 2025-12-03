using System.Linq; //Linq 사용

public class Solution {
    public int solution(int[] num_list) {
        int sum = num_list.Sum();
        int sumSquared = sum * sum;

        int product = num_list.Aggregate(1, (acc, x) => acc * x);
                                    //초기값, (acc누적자,x현재원소) 
        return (product < sumSquared) ? 1 : 0;
    }
}