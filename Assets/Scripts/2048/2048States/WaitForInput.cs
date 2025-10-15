using UnityEngine;
using UnityEngine.InputSystem;

public class WaitForInput : BaseScript
{
    public override void OnEnter(ManageStates manage)
    {

    }
    public override void OnExit(ManageStates manage)
    {

    }
    public override void UpdateState(ManageStates manage)
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


}
