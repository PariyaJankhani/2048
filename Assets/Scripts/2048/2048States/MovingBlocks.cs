using UnityEngine;

public class MovingBlocks : BaseStates 
{

    Tile2 tile2;
    private GameManager manager;
    private GridData GridData;
    //float duration = 0.5f;
    Transform transform;

    public override void OnEnter(GameManager manage)
    {
        EventBroker.instance.MoveNumbers();
       

    }
    public override void OnExit(GameManager manage)
    {

    }
    public override void UpdateState(GameManager manage)
    {

    }

   
}
