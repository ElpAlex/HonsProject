using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SubmitScript : MonoBehaviour
{
    public InputField nameField;
   // public Dropdown genderDrop;

    public Button submitButton;

    //public void CallSubmitInput()
    //{
    //    StartCoroutine(SubmitInput());
    //}

    //IEnumerator SubmitInput()
    //{
    //    WWWForm form = new WWWForm();
    //    form.AddField("name", nameField.text);
    //    form.AddField("gender", genderField.text);
    //    UnityWebRequest www = UnityWebRequest.Post("http://localhost/umaconnect/submitinput.php", form);
    //    yield return www.SendWebRequest();
    //    if(www.downloadHandler.text == "0")
    //    {
    //        Debug.Log("User Input submitted successfully");
    //    }
    //    else
    //    {
    //        Debug.Log("User Input submission failed. Error #" + www.downloadHandler.text);
    //    }
    //}

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 3);
    }

}
