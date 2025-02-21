using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    private void Start()
    {
        Player[] players = new Player[4];
        for (int i = 0; i < players.Length; i++)
        {
            players[i] = new Player();
        }
        int winnerFound = -1;
        Dice dice = new Dice();
        while (winnerFound < 0)
        {
            for (int i = 0; i < players.Length; i++)
            {
                int diceRoll = dice.RollDice();
                bool winner = players[i].DecideAndMovePiece(diceRoll);
                if (winner)
                {
                    winnerFound = i;
                    break;
                }
            }
        }
        Console.WriteLine("winner is player " + winnerFound);
    }
    public int RollDice()
    {
        return Random.Range(1, 7);
    }

}
