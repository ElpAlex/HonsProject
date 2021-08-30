using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyUIButtonsFem : MonoBehaviour
{
    public GameObject DisplayPanel;

    public void ShowPanel()
    {
        DisplayPanel.SetActive(true);
    }
    public void RemovePanel()
    {
        DisplayPanel.SetActive(false);
    }
}
