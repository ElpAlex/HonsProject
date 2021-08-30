using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBodyPanels : MonoBehaviour
{
    //public GameObject GeneralTab;
    public GameObject UpperBodyTab;
    public GameObject LowerBodyTab;

    public Button UpperBodyButton;
    public Button LowerBodyButton;

    // Start is called before the first frame update
    void Start()
    {
        ChangeToUpperBodyTab();
        UpperBodyButton.Select();
    }

    //public void ChangeToGeneralTab()
    //{
    //    GeneralTab.SetActive(true);
    //    UpperBodyTab.SetActive(false);
    //    LowerBodyTab.SetActive(false);
    //}

    public void ChangeToUpperBodyTab()
    {
        //GeneralTab.SetActive(false);
        UpperBodyTab.SetActive(true);
        LowerBodyTab.SetActive(false);
        UpperBodyButton.Select();
    }

    public void ChangeToLowerBodyTab()
    {
        //GeneralTab.SetActive(false);
        UpperBodyTab.SetActive(false);
        LowerBodyTab.SetActive(true);
        LowerBodyButton.Select();
    }
}
