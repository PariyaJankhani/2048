using UnityEngine;

public class Tile : MonoBehaviour 
{
   
    public bool IsEmpty { get { return transform.childCount == 0; } }

    
}
