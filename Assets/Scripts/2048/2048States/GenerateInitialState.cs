using UnityEngine;

public class GenerateInitialState : BaseStates 
{
    
    public override void OnEnter(GameManager manager)
    {
        manager.gridManager.SpawnRandomTile();
        Debug.Log("State: Generating initial tiles.");
        manager.ChangeState(manager.gameObject.AddComponent<WaitForInput>());
    }

    public override void OnExit(GameManager manager) {
    
    }
    public override void UpdateState(GameManager manager) { 
    
    }
    public override void HandleInput(GameManager manager, MoveDirection direction) {
    
    }
}
