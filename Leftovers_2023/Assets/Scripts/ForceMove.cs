using Leftovers_2DPlatformer;
using UnityEngine;

public class ForceMove : MonoBehaviour
{
    public PhysicsMover playerMover;
    public float distanceToForceMove = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerMover.ForceMoveForward(distanceToForceMove);
        }
    }
}

