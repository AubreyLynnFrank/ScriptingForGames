using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        SimpleTriggerEventBehaviour.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
