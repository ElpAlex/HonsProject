using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemaleToMaleScene : MonoBehaviour
{
    //public GameObject MainFemaleScene;

    public GameObject FemaleModel;
    public GameObject MaleModel;

    // Start is called before the first frame update
    void Start()
    {
        ///FemaleModel.SetActive(false);
        //MaleObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if(MainFemaleScene.activeInHierarchy)
        //{
           // FemaleModel.SetActive(true);
           // MaleObject.SetActive(false);
       // }
        //else
       // {
            FemaleModel.SetActive(false);
            MaleModel.SetActive(true);
       // }
    }
}
