using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR.Haptics;

public class WaitForInput : BaseStates
{
    
    
   
    public override void OnEnter(GameManager manage)
    {
       
       

    }
    
    public override void OnExit(GameManager manage)
    {
        
           
           
    }

    public override void UpdateState(GameManager manage)
    {


    }

    public void HandleInput(GameManager manage)
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            manage.currentDirection = MoveDirection.Up;
            manage.ChangeState(manage.posibleMoves);
            manage.posibleMoves.OnEnter(manage);
            Debug.Log("up is pressed!");

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            manage.currentDirection = MoveDirection.Down;
            manage.ChangeState(manage.posibleMoves);
            manage.posibleMoves.OnEnter(manage);

            Debug.Log("down is pressed!");
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            manage.currentDirection = MoveDirection.Left;
            manage.ChangeState(manage.posibleMoves);
            manage.posibleMoves.OnEnter(manage);

            Debug.Log("left is pressed!");
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            manage.currentDirection = MoveDirection.Right;
            manage.ChangeState(manage.posibleMoves);
            manage.posibleMoves.OnEnter(manage);
            Debug.Log("right is pressed!");
        }



    }


}
