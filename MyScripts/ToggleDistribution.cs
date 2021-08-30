using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleDistribution : MonoBehaviour
{
    //int masculine;
    //int feminine;
    //int neutral;

    public Toggle toggle;
    public int count;



    //public void plusOneMasc()
    //{
    //    masculine += 7;
    //    Debug.Log("masc = " + masculine + " fem = " + feminine + " neut = " + neutral);

    //}
    //public void plusOneFem()
    //{
    //    feminine += 7;
    //    Debug.Log("masc = " + masculine + " fem = " + feminine + " neut = " + neutral);
    //}
    //public void plusOneNeut()
    //{
    //    neutral += 7;
    //    Debug.Log("masc = " + masculine + " fem = " + feminine + " neut = " + neutral);
    //}

    void Update()
    {
        if (toggle.isOn)
            count = 7;
        
        else
            count = 1;
        //print(count);
    }

}
