using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private BaseStates currentState;
    [SerializeField] public GridManager gridManager;
    [SerializeField] public GridData gridData;
    
    public void Start()
    {
        if (gridManager == null)
            gridManager = GetComponent<GridManager>();

        if (gridManager != null && gridData != null)
        {
            gridManager.Initialize(gridData);
            gridManager.GenerateGrid();
        }

       
        ChangeState(gameObject.AddComponent<GenerateInitialState>());
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