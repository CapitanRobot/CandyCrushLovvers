using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{
    public  int coordenadaX;
    public  int coordenadaY; 

    public void Coordenada(int X, int Y)
    {
        coordenadaX = X;
        coordenadaY = Y;
    }
}
