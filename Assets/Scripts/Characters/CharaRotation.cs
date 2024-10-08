using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private CharaController rotationController;

    private void Awake()
    {
        rotationController = GetComponent<CharaController>();
    }

    void Start()
    {
        rotationController.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        Rotate(newAimDirection);
    }

    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
