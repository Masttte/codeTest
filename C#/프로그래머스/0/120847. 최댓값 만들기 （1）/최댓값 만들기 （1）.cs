using System;

public class Solution {
    public int solution(int[] numbers) {
        // 1. 배열을 정렬합니다, 공부를 위해 음수가 있다고 가정합니다.
        // 예를 들어, [-5, 2, 8, -10]은 [-10, -5, 2, 8]이 됩니다.
        Array.Sort(numbers);
        
        int n = numbers.Length;
        
        // 2. 가장 작은 두 수의 곱 (음수 * 음수 = 큰 양수)
        // 정렬된 배열의 맨 앞 두 원소의 곱입니다.
        int productMinTwo = numbers[0] * numbers[1];
        
        // 3. 가장 큰 두 수의 곱 (양수 * 양수 = 큰 양수)
        // 정렬된 배열의 맨 뒤 두 원소의 곱입니다.
        int productMaxTwo = numbers[n - 1] * numbers[n - 2];
        
        // 4. 두 곱 중 최댓값을 반환합니다.
        // Math.Max를 사용하여 두 값 중 큰 값을 선택합니다.
        return Math.Max(productMinTwo, productMaxTwo);
    }
}
