using Unity.VisualScripting;
using UnityEngine;

public abstract class BaseStates
{
    public abstract void OnEnter(GameManager manage);
    public abstract void OnExit(GameManager manage);
    public abstract void UpdateState(GameManager manage);
    public abstract void HandleInput(GameManager manage, MoveDirection direction );

}
