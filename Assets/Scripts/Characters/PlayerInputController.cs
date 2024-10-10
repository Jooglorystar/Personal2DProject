using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharaController
{
    private Camera _camera;

    private float PlayerX;
    private float PlayerY;

    protected override void Awake()
    {
        base.Awake();
        _camera = Camera.main;
    }

    private void Update()
    {
        PlayerX = transform.position.x;
        PlayerY = transform.position.y;

        _camera.transform.position = new Vector3(PlayerX, PlayerY, _camera.transform.position.z);
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput;

        moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }
}
