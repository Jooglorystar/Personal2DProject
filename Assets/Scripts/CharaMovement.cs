using System;
using System.Xml.Serialization;
using UnityEngine;

public class CharaMovement : MonoBehaviour
{
    private CharaController movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        movementController = GetComponent<CharaController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        movementController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        // 움직임함수 작동
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        // 방향 설정
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        // 움직임 함수
        direction = direction * 15;

        movementRigidbody.velocity = direction;
    }
}