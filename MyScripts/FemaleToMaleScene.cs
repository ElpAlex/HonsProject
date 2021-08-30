using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//changing the scene from the one of the customization of the female model to the one of the male model
public class FemaleToMaleScene : MonoBehaviour
{
    public GameObject FemaleModel;
    public GameObject MaleModel;

    void Update()
    {
        
            FemaleModel.SetActive(false);
            MaleModel.SetActive(true);
      
    }
}
