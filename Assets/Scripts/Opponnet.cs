using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Opponnet : MonoBehaviour
{
    public NavMeshAgent OppennetAgent;
    public GameObject target;
    private Vector3 oppenetStartPos;

    void Start()
    {
        OppennetAgent = GetComponent<NavMeshAgent>();
        oppenetStartPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        OppennetAgent.SetDestination(target.transform.position);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Collision"))
        {
            transform.position = oppenetStartPos;
        }
    }
}
