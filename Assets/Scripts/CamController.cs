using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Transform camTarget;
    public Transform lookTarget;
    public float camSpeed;
    public Vector3 dist;

    private void LateUpdate()
    {
        Vector3 dPos = camTarget.position + dist;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, camSpeed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget);
    }

}
