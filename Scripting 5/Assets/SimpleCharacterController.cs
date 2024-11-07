using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireCompnent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
   public float jumpForce = 8f;
   public float gravity = -9.81f;

   private CharacterController controller;
   private Vector3 velocity;
   private Transform thisTransform;

    private void Start()
    {
        SimpleCharacterController = GetComponent<CharacterController>();
        theTransorm = transform;
    }

    // Update is called once per frame
    private void Update()
    {
       MoveCharacter();
       ApplyGravity():
       KeepCharacterOnAxis(); 
    }
    private void MoveCharacter()
    {
        var moveInput:float = moveInput.GetAxis("Horizontal");
        var move :Vector3 = new Vector3 (X:moveInput, Y:0f, z:0f) * (moveSpeed * Time.deltaTime);
       controller.Move(move);

       if (moveInput.GetButtonDown("Jump") && controller.isGrounded)
       {
        velocity.y Mathf.Sqrt(jumpForce * -2f * gravity);
       }
    }
    private void ApplyGravity()
    {
        if (!controller.isGrounded)
        {
            velocity. y += gravity * Time.deltaTime;
        }   
        else
        {
            velocity.y = 0f: 
        }

        controller.Move(motion: velocity * Time.deltaTime);
    }
    private void keepCharacteronXAxis()
    {
        var currentPosition: Vector3 = thisTransform.position;
        currentPosition Position.z = 0f;
        thisTransform.position = currentPosition;
   }
}
