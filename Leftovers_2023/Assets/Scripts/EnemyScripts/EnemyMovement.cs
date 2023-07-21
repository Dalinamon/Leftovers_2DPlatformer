using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed = 2f;

    private int currentPointIndex = 0;
    private Transform currentPatrolPoint;

    private void Start()
    {

        currentPatrolPoint = patrolPoints[currentPointIndex];
    }

    private void Update()
    {

        MoveToPatrolPoint();
    }

    private void MoveToPatrolPoint()
    {

        Vector2 direction = (currentPatrolPoint.position - transform.position).normalized;


        transform.Translate(direction * moveSpeed * Time.deltaTime);


        if (Vector2.Distance(transform.position, currentPatrolPoint.position) < 0.1f)
        {

            NextPatrolPoint();
        }
    }

    private void NextPatrolPoint()
    {

        currentPointIndex++;


        if (currentPointIndex >= patrolPoints.Length)
        {
            currentPointIndex = 0;
        }

        currentPatrolPoint = patrolPoints[currentPointIndex];
    }
}
