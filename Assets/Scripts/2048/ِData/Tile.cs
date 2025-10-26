using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour 
{
   
    public bool IsEmpty { get { return transform.childCount == 0; } }
    public Vector2Int gridPosition;
    public Vector2Int targetPos;
    public bool merged;
    public int value;
}
