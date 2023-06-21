using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Collect collect;
    [SerializeField] private float xSpeed;
    public float forwardSpeed;
    private float touchX = 0;
    private float limitX = 20;
    private float newXValue;
    public bool isMoving;
    public bool isThrow;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        SwipeCheck();
        Shoot();
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
            animator.SetBool("IsMove", true);
            isMoving = true;

        }

    }
    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space) && collect.addBomb == true)
        {
            collect.bombIcon.SetActive(false);
            collect.addBomb = false;
            animator.SetBool("IsThrow", true);
            isThrow = true;
        }
        else
        {
            animator.SetBool("IsThrow", false);
            isThrow = false;
        }



    }


}

