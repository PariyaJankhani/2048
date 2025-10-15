using UnityEngine;

public class Tile : MonoBehaviour 
{
    public Color tilecolor;
    public Vector3 tilePosition;
    public bool IsEmpty { get { return transform.childCount == 0; } }

    public Tile(Color tilecolor, Vector3 tilePosition)
    {
      tilecolor = gameObject.GetComponent<Color>();
        tilePosition = gameObject.GetComponent<Vector3>();
            
    }
}
