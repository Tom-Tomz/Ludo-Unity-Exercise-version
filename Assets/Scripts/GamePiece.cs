using System.Numerics;
using UnityEngine;

public class GamePiece : MonoBehaviour
{
    private int position=0;

    void Start()
    {
        UnityEngine.Vector3 pos = transform.position;
    }
    public int Position { get => position; }

    public void Move(int x)
    {
        position += x;
        transform.position;

    }
}