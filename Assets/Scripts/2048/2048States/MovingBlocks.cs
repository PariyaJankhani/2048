using UnityEngine;

public class MovingBlocks : BaseStates
{

    Tile2 tile2;
    private GameManager manager;
    private GridData GridData;
    float duration = 0.5f;
    Transform transform;

    public override void OnEnter(GameManager manage)
    {
        HandleInput(manage,MoveDirection.Up);
        HandleInput(manage, MoveDirection.Down);
        HandleInput(manage, MoveDirection.Left);
        HandleInput(manage, MoveDirection.Right);

    }
    public override void OnExit(GameManager manage)
    {

    }
    public override void UpdateState(GameManager manage)
    {

    }

    public void HandleInput(GameManager manage, MoveDirection direction)
    {


        if (direction == MoveDirection.Down)
        {
            LeanTween.moveY(manage.gameObject,transform.position.y, duration);
        }



        else if (direction == MoveDirection.Up)
        {
            LeanTween.moveY(manage.gameObject, manage.Gridy, duration);
            
        }



        else if (direction == MoveDirection.Left)
        {
            LeanTween.moveX(manage.gameObject, manage.Gridx, duration);
           
        }

        else if (direction == MoveDirection.Right)
        {
            LeanTween.moveX(manage.gameObject, manage.Gridx, duration);
            Debug.Log("start!");
        }

    }

}
