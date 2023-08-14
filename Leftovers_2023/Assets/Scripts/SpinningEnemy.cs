using System.Collections;
using UnityEngine;

public class SpinningEnemy : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float movementSpeed = 3.0f;
    public float baseSpinSpeed = 360.0f;

    private bool movingToA = true;
    private Vector3 initialScale;
    private float currentSpinSpeed;

    private void Start()
    {
        initialScale = transform.localScale;
        currentSpinSpeed = baseSpinSpeed;
    }

    private void Update()
    {
        if (movingToA)
        {
            RotateAndMove(pointA.position);
        }
        else
        {
            RotateAndMove(pointB.position);
        }
    }

    private void RotateAndMove(Vector3 targetPosition)
    {
        Vector3 direction = targetPosition - transform.position;
        float distanceToTarget = direction.magnitude;
        float rotationStep = currentSpinSpeed * Time.deltaTime;

        transform.Rotate(Vector3.forward, rotationStep);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);

        if (distanceToTarget <= movementSpeed * Time.deltaTime)
        {
            movingToA = !movingToA;
            UpdateScale();
            UpdateSpinDirection();
        }
    }

    private void UpdateScale()
    {
        if (movingToA)
        {
            transform.localScale = new Vector3(initialScale.x, initialScale.y, initialScale.z);
        }
        else
        {
            transform.localScale = new Vector3(-initialScale.x, initialScale.y, initialScale.z);
        }
    }

    private void UpdateSpinDirection()
    {
        if (movingToA)
        {
            currentSpinSpeed = baseSpinSpeed;
        }
        else
        {
            currentSpinSpeed = -baseSpinSpeed;
        }
    }
}

