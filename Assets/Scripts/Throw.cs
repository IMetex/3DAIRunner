using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public Collect collect;
    public GameObject ballPrefab;
    public Transform ballExit;
    public Ball ball;
    private Animator animator;
    public bool isThrow;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ThrowBall()
    {
        // If Space press and Add ball collect activite code 
        if ((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0) && collect.addBall == true)
        {
            // Visibility
            collect.ballIcon.SetActive(false);
            // Add collect
            collect.addBall = false;
            // Throw Animation 
            animator.SetBool("IsThrow", true);
            isThrow = true;
            // Create ball
            Instantiate(ballPrefab, ballExit.position, Quaternion.identity);

        }
        else
        {
            // Throw Animation
            animator.SetBool("IsThrow", false);
            isThrow = false;
        }
    }
}
