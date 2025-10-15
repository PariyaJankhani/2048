using System;
using UnityEngine;

public class GridClass : MonoBehaviour
{
    public Tile[,] tiles;
    

    void Start()
    {
        
    }

    void Update()
    {
        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {

                tiles[x, y].name = $"tile {x}{y}";
            }

        }
    }
}
