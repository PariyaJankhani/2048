using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR.Haptics;

public class WaitForInput : BaseStates
{

    Tile2 tile2;
    
    private GameManager manager;
     float duration = 0.5f;

    public WaitForInput(GameManager manager)
    {
        this.manager = manager;
    }
    public override void OnEnter(GameManager manage)
    {
         
        
    }
    
    public override void OnExit(GameManager manage)
    {

    }
    public override void UpdateState(GameManager manage)
    {
       

    }

    public override void HandleInput(GameManager manage , MoveDirection direction)
    {
       
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            Debug.Log("start!");
            LeanTween.moveY(tile2.gameObject,transform.position.y, duration);
            direction = MoveDirection.Down;


            
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("start!");
            LeanTween.moveY(tile2.gameObject, transform.position.y, duration);
            direction = MoveDirection.Up;
          


        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("start!");
            LeanTween.moveY(gameObject, transform.position.x, duration);
            direction = MoveDirection.Left;
           

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("start!");
            LeanTween.moveY(gameObject, transform.position.x, duration);
            direction = MoveDirection.Right;
            

        }

    }


}
