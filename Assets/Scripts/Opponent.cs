using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Opponent : MonoBehaviour
{
    public NavMeshAgent OpponentAgent;
    public SpeedBooster speedBooster;
    public GameObject target;
    private Vector3 opponentStartPos;

    void Start()
    {
        OpponentAgent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        OpponentAgent.SetDestination(target.transform.position);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlusSpeed"))
        {
           // speedBooster.SpBooster();
        }
    }
}
