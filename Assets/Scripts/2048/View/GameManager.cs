using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GridData[,] gridList;
    //------------------

    private BaseStates currentState;
    [SerializeField] public GridManager gridManager;
    private GridData gridData;
    
    public void Start()
    {
        gridData = new GridData();

        initGridData();

        gridManager.GenerateGrid();

        if (gridManager == null)
            gridManager = GetComponent<GridManager>();

        //if (gridManager != null && gridData != null)
        //{
            //gridManager.GenerateGrid();
            gridManager.Initialize(gridData);
           
        //}

       
        ChangeState(gameObject.AddComponent<GenerateInitialState>());
    }
    private void initGridData()
    {
        gridData = new GridData();
        //-------------------------
        
        //-------------------------

        //-------------------------

        //-------------------------

    }

    public void Update()
    {
        currentState?.UpdateState(this);

       
        if (currentState != null)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
                currentState.HandleInput(this, MoveDirection.Up);
            else if (Input.GetKeyDown(KeyCode.DownArrow))
                currentState.HandleInput(this, MoveDirection.Down);
            
        }
    }

    public void ChangeState(BaseStates newState) 
    {
        if (currentState != null)
        {
            currentState.OnExit(this);
         
            Destroy(currentState);
        }

        currentState = newState;

        if (currentState != null)
            currentState.OnEnter(this);
    }
}