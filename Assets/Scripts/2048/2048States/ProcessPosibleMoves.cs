using NUnit.Framework;
using UnityEngine;

public class ProcessPosibleMoves: BaseStates
{
    Tile tile;
    Tile2 tile2;
    public int[,] logicalgrid;
    public override void OnEnter(GameManager manage)
    {
        Debug.Log("here is process possible moves");
    }
    public override void OnExit(GameManager manage)
    {

    }
    public override void UpdateState(GameManager manage)
    {
              logicalgrid = new int[manage.Gridx, manage.Gridy];


        //   if(manage.currentDirection == MoveDirection.Up)
        //    {
        //        for(int i = 0; i< manage.Gridy; i++)
        //        {

        //        }
        //    }
        //   if(manage.currentDirection == MoveDirection.Down)
        //    {

        //    }
        //   if(manage.currentDirection== MoveDirection.Left)
        //    {

        //    }
        //   if(manage.currentDirection== MoveDirection.Right)
        //    {

        //    }

        //    manage.ChangeState(manage.movingBlocks);
    }

    public override void HandleInput(GameManager manage, MoveDirection direction)
    {

    }
}
