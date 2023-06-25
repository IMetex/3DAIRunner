using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody rb;
    private Vector3 startPos;
    public float maxDistance = 3f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.AddForce(transform.forward * 20000);
        startPos = transform.position;

    }
    private void Update()
    {
        float distance = Vector3.Distance(startPos, transform.position);

        if (distance >= maxDistance)
        {
            StopBall();
        }

    }

    private void StopBall()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.useGravity = true;

    }
}
