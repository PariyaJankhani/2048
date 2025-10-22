using UnityEngine;

public class MovingBlocks: BaseStates
{
    
    Tile2 tile2;
    private GameManager manager;
    float duration = 0.5f;
    Transform transform;

    public override void OnEnter(GameManager manage)
    {

    }
    public override void OnExit(GameManager manage)
    {

    }
    public override void UpdateState(GameManager manage)
    {

    }

    public override void HandleInput(GameManager manage, MoveDirection direction)
    {


        if (direction == MoveDirection.Down)
        {
            LeanTween.moveY(manage.gameObject, manage.gridList.Length, duration);
            Debug.Log("start!");
        }



       else if (direction == MoveDirection.Up)
        {
            LeanTween.moveY(manage.gameObject, manage.gridList.Length, duration);
            Debug.Log("start!");
        }



        else if (direction == MoveDirection.Left)
        {
            LeanTween.moveX(manage.gameObject, manage.gridList.Length, duration);
            Debug.Log("start!");
        }

        else if (direction == MoveDirection.Right)
        {
            LeanTween.moveX(manage.gameObject, manage.gridList.Length, duration);
            Debug.Log("start!");
        }
        
    }
}
