using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        ////string[] callings 의 배열을 순회
        //foreach (string calling in callings)
        //{
        //    //calling 에 해당하는 player 의 index 찾기
        //    int i = Array.IndexOf(players, calling);

        //        //players[i] 와 players[i - 1] 를 swap
        //        string temp = players[i - 1];
        //        players[i - 1] = players[i];
        //        players[i] = temp;
        //}
        // return players;

        // 딕셔너리로 리펙토링
        // 선수 이름(키) -> 현재 순위(값)를 저장하는 Dictionary
        Dictionary<string, int> runtime = new Dictionary<string, int>();
        for (int i = 0; i < players.Length; i++)
        {         //Key(string) //Value(int)
            runtime[players[i]] = i;
        }

        foreach (string calledName in callings)
        {
            //딕셔너리에서 player 의 index 찾기 (아주 빠르게)
            int i = runtime[calledName];

            //딕셔너리 swap
            runtime[players[i]] = i - 1;
            runtime[players[i - 1]] = i;

            //players[i] 와 players[i - 1] 를 swap
            string temp = players[i - 1];
            players[i - 1] = players[i];
            players[i] = temp;
        }

        return players;
    }
}