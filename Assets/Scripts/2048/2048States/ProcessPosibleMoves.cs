using UnityEngine;

public class ProcessPosibleMoves: BaseStates
{
    public override void OnEnter(GameManager manage)
    {
        Debug.Log("here is process possible moves");
    }
    public override void OnExit(GameManager manage)
    {

    }
    public override void UpdateState(GameManager manage)
    {

        manage.ChangeState(manage.movingBlocks);
    }

    public override void HandleInput(GameManager manage, MoveDirection direction)
    {

    }
}
