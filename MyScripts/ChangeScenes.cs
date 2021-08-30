using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenes : MonoBehaviour
{
    public GameObject currScene;
    public GameObject nextScene;

    // Start is called before the first frame update
    void Start()
    {
        currScene.SetActive(true);
    }

    public void ChangeToNextScene() 
    {
        currScene.SetActive(false);
        nextScene.SetActive(true);
    }
}
