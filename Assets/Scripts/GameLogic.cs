using System;
using System.Collections;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEditor.Search;
using UnityEngine;

public class GameLogic : MonoBehaviour

{
    public Player[] players = new Player[4];
    private void Start()
    {
        
        // for (int i = 0; i < players.Length; i++)
        // {
        //     players[i] = new Player();
        // }
        
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("Start cororutine");
        yield return new WaitForSeconds(1);
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
        Debug.Log("Slut cororutine");
    }
    public int Dice()
    {
        int genNumber = UnityEngine.Random.Range(1, 7);
        Debug.Log(genNumber);
        return genNumber;

    }

}
