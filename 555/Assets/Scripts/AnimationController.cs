using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        WalkAnimation();
        JumpAnimation();
    }

    private void JumpAnimation()
    {
        if (rb.velocity.y > 0.01f)
        {
            animator.SetTrigger("playerJump");
        }
        
    }

    private void WalkAnimation()
    {
        Vector3 scale = transform.localScale;
        if (rb.velocity.x < 0)
        {
            scale.x = -(Mathf.Abs(scale.x));
        }
        else if (rb.velocity.x > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;
        animator.SetFloat("playerVelocity", Mathf.Abs(rb.velocity.x));
    }
}
