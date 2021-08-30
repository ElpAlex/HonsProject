using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneBefore : MonoBehaviour
{
    public GameObject currScene;
    public GameObject SceneBefore;

    // Start is called before the first frame update
    void Start()
    {
        currScene.SetActive(true);
    }

    public void ChangeToNextScene()
    {
        currScene.SetActive(false);
        SceneBefore.SetActive(true);
    }
}
