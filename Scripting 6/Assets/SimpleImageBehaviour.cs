using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleImageBehaviour : MonoBehaviour
{
    private SimpleImageBehaviour imageObj;
    public SimpleFloatData DataObj;

    private void Start()
    {
        imageObj = GetComponent <Image>();
    }


    public void UpadteWithFloatData()
    {
     imageObj.fillAmount = DataObj.value;   
    }
}
