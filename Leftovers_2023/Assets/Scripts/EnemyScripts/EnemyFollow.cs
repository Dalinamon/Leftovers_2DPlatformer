using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float followRange; 
    public float stopFollowRange; 

    private Rigidbody2D rb;
    private float distance;

    private bool isPlayerGrounded;
    private Quaternion initialRotation;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        initialRotation = transform.rotation;
    }

    private void Update()
    {
        distance = Mathf.Abs(transform.position.x - player.transform.position.x);

        if (distance < followRange)
        {
            float moveDirection = Mathf.Sign(player.transform.position.x - transform.position.x);
            rb.velocity = new Vector2(moveDirection * speed, rb.velocity.y);
            RotateTowardsPlayer();
        }
        else if (distance > stopFollowRange)
        {
            rb.velocity = Vector2.zero;
            ResetRotation();
        }
    }

    private void RotateTowardsPlayer()
    {
        if (isPlayerGrounded)
        {
            Vector2 direction = player.transform.position - transform.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        else
        {
            transform.rotation = initialRotation;
        }
    }

    private void ResetRotation()
    {
        transform.rotation = initialRotation;
    }

    public void SetPlayerGrounded(bool grounded)
    {
        isPlayerGrounded = grounded;
    }
}


