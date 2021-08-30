using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RadioButtonManager : MonoBehaviour
{
    public string currentValue;

    public void PrintNewGroupValue(Toggle sender)
    {
        // only take notice from Toggle just swtiched to On
        if (sender.isOn)
        {
            currentValue = sender.tag;
            print("option changed to = " + currentValue);
        }
    }
}
