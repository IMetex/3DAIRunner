using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    [Header("Access")]
    public SpeedBooster speedBooster;
    public PlayerFinish playerFinish;
    public AIFinish aiFinish;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
           playerFinish.PlayerWin();
           aiFinish.AISpeedZero();
        }

        if (other.CompareTag("PlusSpeed"))
        {
            // Speed Booster
            speedBooster.SpBooster();
            other.gameObject.SetActive(false);
        }
    }


}
