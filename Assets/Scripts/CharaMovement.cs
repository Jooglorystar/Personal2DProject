using System;
using System.Xml.Serialization;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class CharaMovement : MonoBehaviour
{
    private float playerX;
    private float playerY;

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

    private void Update()
    {
        playerX = transform.position.x;
        playerY = transform.position.y;

        Camera.main.transform.position = new Vector3(playerX, playerY, Camera.main.transform.position.z);
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
        direction = direction * 5;

        movementRigidbody.velocity = direction;
    }
}