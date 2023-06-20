using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBack : MonoBehaviour
{
    private Vector3 playerStartPos;
    private Vector3 opponentStartPos;

    void Start()
    {
     
        playerStartPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        opponentStartPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Collision"))
        {
            transform.position = playerStartPos;
            transform.position = opponentStartPos;
        }
    }
}
