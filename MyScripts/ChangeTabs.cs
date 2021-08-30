using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTabs : MonoBehaviour
{
    public GameObject FaceTabContainer;
    public GameObject BodyTabContainer;
    //public GameObject AttireTabContainer;

    public GameObject MyCamera;
    public GameObject ZoomCamera;
    public GameObject NormalCamPos;

    //void Update()
    //{
    //    FaceTab.onClick.AddListener(ChangeTab)
    //}

    public void ChangeToFace()
    {
        FaceTabContainer.SetActive(true);
        BodyTabContainer.SetActive(false);
        //AttireTabContainer.SetActive(false);
        MyCamera.transform.position = ZoomCamera.transform.position;
    }

    public void ChangeToBody()
    {
        FaceTabContainer.SetActive(false);
        BodyTabContainer.SetActive(true);
       // AttireTabContainer.SetActive(false);
        MyCamera.transform.position = NormalCamPos.transform.position;
    }

    public void ChangeToAttire()
    {
        FaceTabContainer.SetActive(false);
        BodyTabContainer.SetActive(false);
        //AttireTabContainer.SetActive(true);
        MyCamera.transform.position = NormalCamPos.transform.position;
    }
}
