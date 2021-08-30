using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//script thata adds value to the choices of the user in the character attributes stage (works when combined with the CountMasc.cs script)
public class ToggleDistribution : MonoBehaviour
{
    public Toggle toggle;
    public int count;


    void Update()
    {
        if (toggle.isOn)
            count = 7;
        
        else
            count = 1;
    }

}
