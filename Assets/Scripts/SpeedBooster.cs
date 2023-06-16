using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpeedBooster : MonoBehaviour
{
    public PlayerController playerController;
    public Opponnet opponnet;
    public GameObject speedBosster;
    public float plusSpeed = 3f;

    public void SpBooster()
    {
        playerController.forwardSpeed += plusSpeed;
        opponnet.OppennetAgent.speed += plusSpeed;
        speedBosster.SetActive(true);
        StartCoroutine(SlowAfterWhileCoroutine());
    }
    private IEnumerator SlowAfterWhileCoroutine()
    {
        yield return new WaitForSeconds(2f);
        playerController.forwardSpeed -= plusSpeed;
        opponnet.OppennetAgent.speed -= plusSpeed;
        speedBosster.SetActive(false);
    }




}
