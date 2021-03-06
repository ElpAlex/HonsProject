using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script for the UI help button
public class HelpButton : MonoBehaviour
{
    public GameObject infoHelpPanel;
    // Start is called before the first frame update
    void Start()
    {
        infoHelpPanel.SetActive(false);
    }

    public void infoHelpPanelOnOrOff()
    {
        if (infoHelpPanel != null)
        {
            bool isActive = infoHelpPanel.activeSelf;

            infoHelpPanel.SetActive(!isActive);
        }
    }
}
