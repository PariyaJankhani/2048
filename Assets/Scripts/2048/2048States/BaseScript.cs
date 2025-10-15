using Unity.VisualScripting;
using UnityEngine;

public abstract class BaseScript: MonoBehaviour
{
    public abstract void OnEnter(ManageStates manage);
    public abstract void OnExit(ManageStates manage);
    public abstract void UpdateState(ManageStates manage);

}
