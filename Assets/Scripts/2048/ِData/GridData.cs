using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GridData
{
    public Tile tile;
    public Tile2 tile2;

    //----------------------------
    public static GridManager gridManager;

    public Tile2[,] physicalGrid;/*= new Tile2[gridManager.Grid_sizex,gridManager.Grid_sizey];*/

    public Tile[,] PhysicalGrid;/*= new Tile[gridManager.Grid_sizex, gridManager.Grid_sizey];*/

}
