using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : CharaController
{
    [SerializeField][Range(0f, 3f)] private float followRange;
    [SerializeField] private SpriteRenderer characterRenderer;
    GameManager gameManager;
    protected Transform Target { get; private set; }

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        gameManager = GameManager.Instance;
        Target = gameManager.Player;
    }

    void FixedUpdate()
    {
        float distanceToTarget = DistanceToTarget();
        Vector2 directionToTarget = DirectionToTarget();

        Rotate(directionToTarget);
    }

    float DistanceToTarget()
    {
        return Vector3.Distance(transform.position, Target.position);
    }

    Vector2 DirectionToTarget()
    {
        return (Target.position - transform.position).normalized;
    }

    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
