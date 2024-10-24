using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkOnCollision : MonoBehaviour
{
    public float shrinkFactor = 0.13f;
    
    void OnCollisionEnter (Collision collision)
    {
        // Scale the object down when it collides with another object
        transform.localScale *= shrinkFactor;
    }

}
