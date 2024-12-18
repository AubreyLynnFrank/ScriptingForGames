using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTriggerEventBehavior : MonoBehaviour
{
    public unityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
        Debug.Log("Player interacted with the object!");
    }

}
