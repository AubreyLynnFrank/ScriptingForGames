using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTriggerEventBehavior_01 : MonoBehaviour
{
    public unityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEvent(SetTrigger("Hit"))
        triggerEvent.Invoke();
        Debug.Log("Player interacted with the object!");
    }
    // to 
 private void OnTriggerStart(Collider other)
    {
        triggerEvent(SetTrigger("Start"))
        triggerEvent.Invoke();
        Debug.Log("Player started the game!");
    }
    // To remove the fruit when the player gathers it. 
     private void OnTriggerCollide(Collider other)
    {
        triggerEvent(SetTrigger("Collect"))
        triggerEvent.Invoke();
        Debug.Log("Player has gathered the fruit.");
    }
    //to spin the spike heads while the game is running. 
    private void OnTriggerCollide(Collider other)
    {
        triggerEvent(SetTrigger("Spin"))
        triggerEvent.Invoke();
        Debug.Log("The spike head spins.");
    }

// To shake the UI when a player collects an item
        private void OnTriggerCollide(Collider other)
    {
        triggerEvent(SetTrigger("Spin"))
        triggerEvent.Invoke();
        Debug.Log("The spike head spins.");
}