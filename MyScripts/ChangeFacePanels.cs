using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The script is attached to a UI component with tabs referring to the face of the avatar and it allows the user to change from one to the other
public class ChangeFacePanels : MonoBehaviour
{
    public GameObject TopTab;
    public GameObject MiddleTab;
    public GameObject BottomTab;

    public Button TopButton;
    public Button MiddleButton;
    public Button BottomButton;

    // Start is called before the first frame update
    void Start()
    {
        ChangeToTopTab();
        TopButton.Select();
    }

    public void ChangeToTopTab()
    {
        TopTab.SetActive(true);
        MiddleTab.SetActive(false);
        BottomTab.SetActive(false);
        TopButton.Select();
    }

    public void ChangeToMiddleTab()
    {
        TopTab.SetActive(false);
        MiddleTab.SetActive(true);
        BottomTab.SetActive(false);
        MiddleButton.Select();
    }

    public void ChangeToBottomTab()
    {
        TopTab.SetActive(false);
        MiddleTab.SetActive(false);
        BottomTab.SetActive(true);
        BottomButton.Select();
    }
}
