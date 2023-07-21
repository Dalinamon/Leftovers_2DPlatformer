using UnityEngine;

public class FlyingEnemyMovement : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float moveSpeed = 5f;
    public float attackDistance = 3f;
    public float diveForce = 10f;
    public int attackDamage = 1;

    private bool isAttacking = false;
    private Transform target;
    private Rigidbody2D rb;
    private Transform currentTarget;
    private bool movingToNextPoint = true;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        currentTarget = pointB;
    }

    private void Update()
    {
        if (!isAttacking)
        {
            if (movingToNextPoint)
            {
                MoveTowardsTarget();
            }
            else
            {
                AttackPlayer();
            }

            
            float distanceToPlayer = Vector2.Distance(transform.position, target.position);
            if (distanceToPlayer <= attackDistance)
            {
                isAttacking = true;
                rb.velocity = Vector2.zero;
                movingToNextPoint = false;
            }
        }
    }

    private void MoveTowardsTarget()
    {
        
        Vector2 direction = (currentTarget.position - transform.position).normalized;
        rb.velocity = direction * moveSpeed;

        
        if (direction.x > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (direction.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        
        float distanceToTarget = Vector2.Distance(transform.position, currentTarget.position);
        if (distanceToTarget <= 0.1f)
        {
            
            if (currentTarget == pointA)
                currentTarget = pointB;
            else
                currentTarget = pointA;
        }
    }

    private void AttackPlayer()
    {
        
        Vector2 diveDirection = (target.position - transform.position).normalized;
        rb.AddForce(diveDirection * diveForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(attackDamage);
            }

            Destroy(gameObject);
        }
    }
}


