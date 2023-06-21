using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Opponent : MonoBehaviour
{
    private Animator animator;
    public NavMeshAgent OpponentAgent;
    public SpeedBooster speedBooster;
    public GameObject target;
    private Vector3 opponentStartPos;

    void Start()
    {
        OpponentAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (LevelManager.LevelManagerInstance.gameState == true)
        {
            OpponentAgent.SetDestination(target.transform.position);
            animator.SetBool("IsMove", true);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlusSpeed"))
        {
            speedBooster.SpBooster();
            other.gameObject.SetActive(false);
        }
    }
}
