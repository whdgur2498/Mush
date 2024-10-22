using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private int animationChange = 0;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        animationChange++;
        if (animationChange > 3)
        {
            animationChange = 1;
        }
        animator.SetInteger("Click", animationChange); 
    }
}
