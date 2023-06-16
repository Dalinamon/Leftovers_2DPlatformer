using UnityEngine;

public class KnockpackEffect : MonoBehaviour
{
    public float knockbackForce = 5f;
    public float knockbackDuration = 0.5f;

    private Rigidbody2D rb;
    private bool isKnockback = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Player"))
        {
            if (!isKnockback)
            {
                isKnockback = true;
                Vector2 knockbackDirection = (transform.position - collision.transform.position).normalized;
                rb.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);
                Invoke(nameof(ResetKnockback), knockbackDuration);
            }
        }
    }

    private void ResetKnockback()
    {
        isKnockback = false;
    }
}