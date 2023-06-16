using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleaAnimator : MonoBehaviour
{
    public float speed;
    public float  strength;
    private float randomOffset;
    void Start()
    {
        randomOffset = Random.Range(4f,-4f);
    }
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Sin(Time.time * speed + randomOffset) * strength;
        transform.position = pos;
        
    }
}
