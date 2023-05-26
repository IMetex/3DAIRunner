using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public LevelManager levelManager;
    public PlayerController playerController;
    public void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("EndLine"))
        {
            playerController.forwardSpeed = 0;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Collision"))
        {
            levelManager.Again();
        }
    }
}
