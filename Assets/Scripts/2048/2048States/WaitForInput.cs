using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WaitForInput : BaseStates
{

    [SerializeField] private int _width, _height;

    [SerializeField] private Tile tilePrefab;

    [SerializeField] private Transform cam;
    [SerializeField] private Tile2 tile2;



    public override void OnEnter(GameManager manage)
    {

    }
    
    public override void OnExit(GameManager manage)
    {

    }
    public override void UpdateState(GameManager manage)
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("start!");
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("start!");


        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("start!");

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("start!");

        }

    }

    public override void HandleInput(GameManager manage , MoveDirection direction)
    {

    }


}
