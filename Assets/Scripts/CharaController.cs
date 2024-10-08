using System;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    protected CharaDataHandler stats { get; private set; }

    protected virtual void Awake()
    {
        stats = GetComponent<CharaDataHandler>();
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
