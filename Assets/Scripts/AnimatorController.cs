using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator;

    public bool IsMove;
    void Start()
    {
        animator =GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
