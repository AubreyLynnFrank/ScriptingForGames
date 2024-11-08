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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
