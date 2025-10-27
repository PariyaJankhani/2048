using System;
using UnityEngine;

public class EventBroker : MonoBehaviour
{

    public static EventBroker instance;
    private void Awake()
    {
        instance = this;
    }


    public event Action OnNumberMove;

    public void MoveNumbers()
    {
        if(OnNumberMove != null)
            OnNumberMove();
    }
}
