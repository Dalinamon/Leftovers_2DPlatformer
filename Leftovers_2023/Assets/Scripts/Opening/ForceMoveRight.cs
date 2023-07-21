using Leftovers_2DPlatformer;
using UnityEngine;

public class ForceMoveRight : MonoBehaviour
{
    public float forceDuration = 4f;
    public float forceMagnitude = 5f;

    private Rigidbody2D playerRigidbody;
    private PhysicsMover playerMovement;
    private bool isForcingMove = true;
    private float timer = 0f;

    private void Start()
    {
        playerMovement = GetComponent<PhysicsMover>();
        playerMovement.enabled = false;

        playerRigidbody = GetComponent<Rigidbody2D>();
        playerRigidbody.velocity = Vector2.zero;
    }

    private void Update()
    {
        if (isForcingMove)
        {

            playerRigidbody.AddForce(Vector2.right * forceMagnitude, ForceMode2D.Force);

            timer += Time.deltaTime;

            if (timer >= forceDuration)
            {

                playerRigidbody.velocity = Vector2.zero;
                playerMovement.enabled = true;
                isForcingMove = false;
            }
        }
    }
}



