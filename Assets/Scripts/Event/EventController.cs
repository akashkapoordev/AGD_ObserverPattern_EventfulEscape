using System;

public class EventController
{
    public Action baseAction;


    public void AddListener(Action action)
    {
        baseAction += action;
    }

    public void RemoveListener(Action action)
    {
        baseAction -= action;
    }

    public void InvokeAction()
    {
        baseAction?.Invoke();
    }
}
