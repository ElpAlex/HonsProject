using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Changing between face and body UI panels
public class ChangeTabs : MonoBehaviour
{
    public GameObject FaceTabContainer;
    public GameObject BodyTabContainer;

    public GameObject MyCamera;
    public GameObject ZoomCamera;
    public GameObject NormalCamPos;


    public void ChangeToFace()
    {
        FaceTabContainer.SetActive(true);
        BodyTabContainer.SetActive(false);
        MyCamera.transform.position = ZoomCamera.transform.position;
    }

    public void ChangeToBody()
    {
        FaceTabContainer.SetActive(false);
        BodyTabContainer.SetActive(true);
       // AttireTabContainer.SetActive(false);
        MyCamera.transform.position = NormalCamPos.transform.position;
    }
}
