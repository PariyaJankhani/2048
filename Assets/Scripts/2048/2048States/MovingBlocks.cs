using UnityEngine;
using UnityEngine.Assertions.Must;
using static UnityEditor.PlayerSettings;

public class MovingBlocks : BaseStates 
{

    Tile2 tile2;
    private GameManager manager;
    private GridData GridData;
    //float duration = 0.5f;

    public override void OnEnter(GameManager manage)
    {
        Debug.Log("here is moving block");
        //EventBroker.instance.MoveNumbers();

        manage.Tile2prefab.Move();



    }
    public override void OnExit(GameManager manage)
    {

    }
    public override void UpdateState(GameManager manage)
    {
       
       
    }

   
}
