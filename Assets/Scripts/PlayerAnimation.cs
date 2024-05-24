using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Rigidbody2D rb;  
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        SetAnimation();
    }

    void SetAnimation()
    {
        bool isWalking = rb.velocity.sqrMagnitude != 0;
        animator.SetBool("walking", isWalking);
    }
}
