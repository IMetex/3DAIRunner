using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    public Throw throwBall;
    [Header("Speeds Value")]
    [SerializeField] private float xSpeed;
    public float forwardSpeed;
    private float touchX = 0;
    private float limitX = 20;
    private float newXValue;

    [Header("Boolen")]
    public bool isMoving;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        SwipeCheck();
        throwBall.ThrowBall();
    }
    void SwipeCheck()
    {
        if (LevelManager.LevelManagerInstance.gameState == true)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                touchX = Input.GetTouch(0).deltaPosition.x / Screen.width;
            }
            else if (Input.GetMouseButton(0))
            {
                touchX = Input.GetAxis("Mouse X");
            }
            else
            {
                touchX = 0;
            }

            newXValue = transform.position.x + xSpeed * touchX * Time.deltaTime;
            newXValue = Mathf.Clamp(newXValue, -limitX, limitX);

            Vector3 newPosition = new Vector3(newXValue, transform.position.y, transform.position.z + forwardSpeed * Time.deltaTime);

            transform.position = newPosition;

            // Runnin Animation
            animator.SetBool("IsMove", true);
            isMoving = true;

        }

    }
}




