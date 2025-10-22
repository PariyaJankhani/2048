using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour 
{
   
    public bool IsEmpty { get { return transform.childCount == 0; } }
     List<Vector2>emptyposition = new List<Vector2>();    
}
