using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    public LevelManager levelManager;
    public PlayerController playerController;
    public SpeedBooster speedBooster;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EndLine"))
        {
            playerController.forwardSpeed = 0f;
            transform.Rotate(transform.position.x, -180, transform.position.z, Space.Self);
            //levelManager.RestartPanel.SetActive(true);
        }
        if (other.CompareTag("PlusSpeed"))
        {
            // Speed Booster
            speedBooster.SpBooster();

        }
    }

}
