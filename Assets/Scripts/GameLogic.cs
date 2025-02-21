using System;
using System.Collections;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEditor.Search;
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
        while (winnerFound < 0)
        {
            for (int i = 0; i < players.Length; i++)
            {
                int diceRoll = Dice();
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
    public int Dice()
    {
        int genNumber = UnityEngine.Random.Range(1, 7);
        Debug.Log(genNumber);
        return genNumber;

    }

}
