using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpeedBooster : MonoBehaviour
{
    public PlayerController playerController;

    public Opponent opponent1;
    public Opponent opponent2;

    public GameObject speedIcon;
    public float plusSpeed = 3f;

    public void SpBooster()
    {
        // Player and AI speed boost 
        speedIcon.SetActive(true);
        playerController.forwardSpeed += plusSpeed;
        
        // AI player
        opponent1.OpponentAgent.speed += plusSpeed;
        opponent2.OpponentAgent.speed += plusSpeed;

        StartCoroutine(SlowAfterWhileCoroutine());
    }
    private IEnumerator SlowAfterWhileCoroutine()
    {
        // Speed Boost time after off
        yield return new WaitForSeconds(2f);
        speedIcon.SetActive(false);
        playerController.forwardSpeed -= plusSpeed;
        
        // AI player
        opponent1.OpponentAgent.speed -= plusSpeed;
        opponent2.OpponentAgent.speed -= plusSpeed;

    }




}