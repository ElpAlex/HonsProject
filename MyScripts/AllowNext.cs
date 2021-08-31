using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//A script that allows the user to press next and go to the main scene
public class AllowNext : MonoBehaviour
{
    public Button nextButton;

    public InputField usernameField;
    public InputField ageField;
    public InputField genderField;

//this allows the user to continue only if they are over 18 years old and they type male/Male/Female/female/other in the gender box
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
        
    }
}
