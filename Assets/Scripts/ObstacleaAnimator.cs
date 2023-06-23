using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleaAnimator : MonoBehaviour
{
    public float speed;
    public float strength;
    private float randomOffset;
    void Start()
    {
        randomOffset = Random.Range(20f, -20f);
    }
    void Update()
    {
        if (LevelManager.LevelManagerInstance.gameState == true)
        {
            Vector3 pos = transform.position;
            pos.x = Mathf.Sin(Time.time * speed + randomOffset) * strength;
            transform.position = pos;
        }
    }
}
