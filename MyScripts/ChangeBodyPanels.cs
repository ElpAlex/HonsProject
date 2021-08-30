using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The script is attached to a UI component with tabs referring to the body of the avatar and it allows the user to change from one to the other
public class ChangeBodyPanels : MonoBehaviour
{
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

    public void ChangeToUpperBodyTab()
    {
        UpperBodyTab.SetActive(true);
        LowerBodyTab.SetActive(false);
        UpperBodyButton.Select();
    }

    public void ChangeToLowerBodyTab()
    { 
        UpperBodyTab.SetActive(false);
        LowerBodyTab.SetActive(true);
        LowerBodyButton.Select();
    }
}
