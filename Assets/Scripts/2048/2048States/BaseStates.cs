using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class BaseStates
{
    public abstract void OnEnter(GameManager manage);
    public abstract void OnExit(GameManager manage);
    public abstract void UpdateState(GameManager manage);

    private List<IObserver> observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }
    protected void NotifyObserver(MoveDirection direction)
    {
        observers.ForEach((observer) =>
        {
            observer.OnNotify(direction);
        });
    }

}
