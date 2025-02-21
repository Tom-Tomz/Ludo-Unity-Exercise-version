using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            pieces[i] = Instantiate(Gamepiece, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
    GameObject[] pieces = new GameObject[4];
    public GameObject Gamepiece;
    
    public bool DecideAndMovePiece(int rollValue)
    {
        if (rollValue == 6)
        {
            for (int i = 0; i < pieces.Length; i++)
            {
                if (pieces[i].GetComponent<GamePiece>().Position == 0)
                {
                    pieces[i].GetComponent<GamePiece>().Move(1);
                    return false;
                }
            }
        }
        else
        {
            for (int i = 0; i < pieces.Length; i++)
            {
                if (pieces[i].GetComponent<GamePiece>().Position+rollValue <= 40)
                {
                    pieces[i].GetComponent<GamePiece>().Move(rollValue);
                    return false;
                }
            }
        }
        for (int i = 0; i < pieces.Length; i++) {
            if (pieces[i].GetComponent<GamePiece>().Position < 40)
            {
                pieces[i].GetComponent<GamePiece>().Move(rollValue);
                return false;
            }
        }
        return true;
    }
}
