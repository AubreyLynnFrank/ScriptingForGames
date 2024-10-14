// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        // Move the target GameObject
        var x:float = Mathf.PingPong(t:Time.time, length:3);
        var p = new Vector3(x:0, y:x, z:0);
        transform.position = p;

        //Rotate the target GameObject
        transform.Rotate(eulers:new Vector3 (x:0, y:30, z:0) * Time.deltaTime);

        // challenge task: slide
        var x = Mathf.PingPong(Time.time, 3); transform.position = new Vector3(x, 0, 0);
    }
}
