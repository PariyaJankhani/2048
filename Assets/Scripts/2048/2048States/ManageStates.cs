using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;

public class ManageStates: MonoBehaviour
{
     BaseScript currentState;
     WaitForInput wait = new WaitForInput();
     MonoBehaviour mono = new MonoBehaviour();
     ProcessPosibleMoves posibleMoves = new ProcessPosibleMoves();
     CompleteTheGrid completeTheGrid = new CompleteTheGrid();
     CheckComplete CheckComplete = new CheckComplete();

    public void Start()
    {
        //currentState = GetComponent<BaseScript>();
        currentState = wait;
        currentState.OnEnter(this);
        

    }

    public void Update()
    {
        currentState.UpdateState(this);
    }

    public void switchStates(BaseScript state)
    {
        currentState = state;
        state.OnEnter(this);
    }


}
