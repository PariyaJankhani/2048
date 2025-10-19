using System;
using UnityEngine;


[System.Serializable]
public class GridData
{
    public const int Grid_size = 4;

    public int[,] LogicGrid = new int[Grid_size, Grid_size];

    public Tile2[,] physicalGrid = new Tile2[Grid_size, Grid_size];
    

}
