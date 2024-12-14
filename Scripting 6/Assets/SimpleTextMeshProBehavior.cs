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

    // shake text when the player collects and item.
    private TextMeshProUGUI textObj;
    public int value (UpdateValue(int amount))
        value += amount; 

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
