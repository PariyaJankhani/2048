using UnityEngine;
using static UnityEditor.PlayerSettings;

public class MovingBlocks : BaseStates 
{

    Tile2 tile2;
    private GameManager manager;
    private GridData GridData;
    float duration = 0.5f;
    Transform transform;

    public override void OnEnter(GameManager manage)
    {
        //EventBroker.instance.MoveNumbers();
        int sizeX = manage.gridList.GetLength(0);
        int sizey = manage.gridList.GetLength(1);

        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizey; y++)
            {

                GridData cell = manage.gridList[x, y];
                if (cell != null || cell.tile2 == null)
                    continue;

                Vector2Int target = cell.tile2.targetPosition;
                Vector3 worldtarget = new Vector3(target.x, target.y, 0);

                LeanTween.move(cell.tile2.gameObject, worldtarget, duration).setEaseInOutQuad();

            }
        }

    }
    public override void OnExit(GameManager manage)
    {

    }
    public override void UpdateState(GameManager manage)
    {
       
       
    }

   
}
