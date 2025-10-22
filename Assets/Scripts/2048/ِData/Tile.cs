using NUnit.Framework;
using UnityEngine;

public class Tile : MonoBehaviour 
{
   
    public bool IsEmpty { get { return transform.childCount == 0; } }
    //List<Vector2Int> emptyposition = new List<Vector2Int>();
    
}
