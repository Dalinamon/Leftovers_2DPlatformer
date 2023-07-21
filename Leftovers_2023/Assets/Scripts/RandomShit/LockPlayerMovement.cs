using Leftovers_2DPlatformer;
using UnityEngine;

public class LockPlayerMovement : MonoBehaviour
{
    private bool playerIsLocked = false;
    private Rigidbody2D playerRigidbody;
    private PhysicsMover playerMovement;

    private void Start()
    {
        playerRigidbody = FindObjectOfType<Rigidbody2D>();

        playerMovement = FindObjectOfType<PhysicsMover>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsLocked = true;
            playerMovement.enabled = false;
            playerRigidbody.velocity = Vector2.zero;
        }
    }

    private void Update()
    {

        if (playerIsLocked && Input.GetKeyDown(KeyCode.Space))
        {
            UnlockPlayer();
        }
    }

    private void UnlockPlayer()
    {
        playerIsLocked = false;
        playerMovement.enabled = true;
    }
}

