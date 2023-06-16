using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class ClickMove : MonoBehaviour
{
    NavMeshAgent nm_Agent;
    RaycastHit nm_Hitİnfo = new RaycastHit();

    void Start()
    {
        nm_Agent = GetComponent<NavMeshAgent>();

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin,ray.direction,out nm_Hitİnfo))
            {
                nm_Agent.destination = nm_Hitİnfo.point;
            }
        }

    }
}
