using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

[RequireCompnonent (typeof(TextMeshProUGUI))]
public class SimpleTextMeshProBehavior : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public SimpleIntData dataObj;

    private void start()
    {
        textObj = GetComponent <TextMeshProGUI>();
        UpdateWithIntData();
    }

    {
        public void UpdateWithIntData()
        {
            textObj.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
