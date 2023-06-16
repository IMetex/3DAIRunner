using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
   
    public LevelManager levelManager;
    public PlayerController playerController;
    public SpeedBooster speedBooster;
    private Vector3 playerStartPos;

    private void Start()
    {
        playerStartPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EndLine"))
        {
            playerController.forwardSpeed = 0f;
            transform.Rotate(transform.position.x, -180, transform.position.z, Space.Self);
            levelManager.RestartPanel.SetActive(true);
        }
        if (other.CompareTag("PlusSpeed"))
        {
           speedBooster.SpBooster();
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Collision"))
        {
            transform.position = playerStartPos;
        }
    }


}
