using Proyecto26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserDataMale : MonoBehaviour
{
    public static string playerName;
    public InputField nameText;

    public static string playerAge;
    public InputField ageText;

    public static string playerGender;
    public InputField genderText;


    //UpperBody
    public static float breastsValue;
    public Slider breasts;

    public static float waistValue;
    public Slider waist;
   

    //LowerBody
    public static float gluteusValue;
    public Slider gluteus;


    //Androgynous
    public static string androgynousOrNot;
    public CountMasc androgynousOrNotText;


    //Questionnaire toggles
    public static string questionOneAnswer;
    public RadioButtonManager toggleGroup1;

    public static string questionTwoAnswer;
    public RadioButtonManager toggleGroup2;

    public static string questionThreeAnswer;
    public RadioButtonManager toggleGroup3;

    public static string questionFourAnswer;
    public RadioButtonManager toggleGroup4;

    public static string questionFiveAnswer;
    public RadioButtonManager toggleGroup5;

    public static string questionSixAnswer;
    public RadioButtonManager toggleGroup6;

    public static string questionSevenAnswer;
    public RadioButtonManager toggleGroup7;

    public static string questionEightAnswer;
    public RadioButtonManager toggleGroup8;

    public static string questionNineAnswer;
    public RadioButtonManager toggleGroup9;

    public static string questionTenAnswer;
    public RadioButtonManager toggleGroup10;

    public static string questionElevenAnswer;
    public RadioButtonManager toggleGroup11;


    public void OnSubmit()
    {
        playerName = nameText.text;
        playerAge = ageText.text;
        playerGender = genderText.text;


        


        //bodyUpper
        breastsValue = breasts.value;
        waistValue = waist.value;

        //bodylower
        gluteusValue = gluteus.value;

        //Androgynous
        androgynousOrNot = androgynousOrNotText.finalAndrogyny;

        //questionnaire
        questionOneAnswer = toggleGroup1.currentValue;
        questionTwoAnswer = toggleGroup2.currentValue;
        questionThreeAnswer = toggleGroup3.currentValue;
        questionFourAnswer = toggleGroup4.currentValue;
        questionFiveAnswer = toggleGroup5.currentValue;
        questionSixAnswer = toggleGroup6.currentValue;
        questionSevenAnswer = toggleGroup7.currentValue;
        questionEightAnswer = toggleGroup8.currentValue;
        questionNineAnswer = toggleGroup9.currentValue;
        questionTenAnswer = toggleGroup10.currentValue;
        questionElevenAnswer = toggleGroup11.currentValue;

        PostToDataBase();
    }

    private void PostToDataBase()
    {
        User user = new User();
        RestClient.Put(url: "https://umaconnect-669eb-default-rtdb.europe-west1.firebasedatabase.app/" + playerName + ".json", user);
    }
}
