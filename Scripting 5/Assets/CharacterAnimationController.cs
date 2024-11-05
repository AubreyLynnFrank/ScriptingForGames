using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
   private Animator animator;
       void Start()
    {
        // Cache the Animator component attafched to CharacterArt
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        HandleAnimations();
    }
    private void HandleAnimations()
    {
        // Handle running and idling
        if (Input.GetAxis("Horizontal")!= 0)
        {
            animator.SetTrigger(name: "Run");
        }
        else 
        {
            animator.SetTrigger(name: "Idle");
        }
        // handle jumping
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger(name: "Jump")
        }
        if (Input,GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger(nameof: "WallJump");
        }
    }
}
