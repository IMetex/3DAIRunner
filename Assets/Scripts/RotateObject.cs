using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
   [SerializeField] private Vector3 rotation;

    void FixedUpdate()
    {
        // object rotation
         transform.Rotate(rotation,Space.World);
    }
}
