using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllowNext : MonoBehaviour
{
    public Button nextButton;

    public InputField usernameField;
    public InputField ageField;
    public InputField genderField;

    void Update()
    {
        nextButton.interactable = (usernameField.text.Length >= 1 && ageField.text.Length ==2

            && ageField.text != "10"
            && ageField.text != "11"
            && ageField.text != "12"
            && ageField.text != "13"
            && ageField.text != "14"
            && ageField.text != "15"
            && ageField.text != "16"
            && ageField.text != "17" && 
            (genderField.text == "Male" || genderField.text == "male"|| genderField.text == "Female" || genderField.text == "female" || genderField.text == "Other" || genderField.text == "other"));
        //nextButton.interactable = (usernameField.text.);
    }
}
