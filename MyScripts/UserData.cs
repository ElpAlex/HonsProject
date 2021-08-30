using Proyecto26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData : MonoBehaviour
{
    public static string playerName;
    public InputField nameText;

    public static string playerAge;
    public InputField ageText;

    public static string playerGender;
    public InputField genderText;

    ////faceTop
    //public static float foreheadPosValue;
    //public Slider foreheadPos;

    //public static float foreheadSizeValue;
    //public Slider foreheadSize;

    //public static float eyesRotValue;
    //public Slider eyesRot;

    //public static float eyesSizeValue;
    //public Slider eyesSize;

    //public static float eyesSpacingValue;
    //public Slider eyesSpacing;

    //public static float earsSizeValue;
    //public Slider earsSize;

    //public static float earsPosValue;
    //public Slider earsPos;

    ////faceMiddle
    //public static float nosePosValue;
    //public Slider nosePos;

    //public static float nosePronValue;
    //public Slider nosePron;

    //public static float noseSizeValue;
    //public Slider noseSize;

    //public static float noseWidthValue;
    //public Slider noseWidth;

    //public static float cheekPosValue;
    //public Slider cheekPos;

    //public static float cheekSizeValue;
    //public Slider cheekSize;

    //public static float mouthSizeValue;
    //public Slider mouthSize;

    //public static float lipsSizeValue;
    //public Slider lipsSize;

    ////faceBottom
    //public static float jawsPosValue;
    //public Slider jawsPos;

    //public static float jawsSizeValue;
    //public Slider jawsSize;

    //public static float chinPosValue;
    //public Slider chinPos;

    //public static float chinPronValue;
    //public Slider chinPron;

    //public static float chinSizeValue;
    //public Slider chinSize;

    //public static float mandibleSizeValue;
    //public Slider mandibleSize;

    //public static float neckThickValue;
    //public Slider neckThick;

    //FEMALE

    //UpperBody
    //public static float armsValue;
    //public Slider arms;

    //public static float shouldersValue;
    //public Slider shoudlers;

    public static float breastsFemValue;
    public Slider breastsFem;

    //public static float abdomenValue;
    //public Slider abdomen;

    public static float waistFemValue;
    public Slider waistFem;

    //public static float bellyValue;
    //public Slider belly;

    //LowerBody
    public static float gluteusFemValue;
    public Slider gluteusFem;

    //public static float thighsValue;
    //public Slider thighs;

    //public static float calvesValue;
    //public Slider calves;

    //public static float feetValue;
    //public Slider feet;

    ////Other
    //public static float heightValue;
    //public Slider height;

    //public static float weightValue;
    //public Slider weight;

    //MALE
    public static float armsMValue;
    public Slider armsM;

    public static float shouldersMValue;
    public Slider shouldersM;

    public static float abdomenMValue;
    public Slider abdomenM;

    //AndrogynousFem
    public static string androgynousOrNotFem;
    public CountMasc androgynousOrNotTextFem;

    //AndrogynousMale
    public static string androgynousOrNotM;
    public CountMasc androgynousOrNotTextM;


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


        ////faceTop
        //foreheadPosValue = foreheadPos.value;
        //foreheadSizeValue = foreheadSize.value;
        //eyesRotValue = eyesRot.value;
        //eyesSizeValue = eyesSize.value;
        //eyesSpacingValue = eyesSpacing.value;
        //earsSizeValue = earsSize.value;
        //earsPosValue = earsPos.value;
        ////faceMiddle
        //nosePosValue = nosePos.value;
        //nosePronValue = nosePron.value;
        //noseSizeValue = noseSize.value;
        //noseWidthValue = noseWidth.value;
        //cheekPosValue = cheekPos.value;
        //cheekSizeValue = cheekSize.value;
        //mouthSizeValue = mouthSize.value;
        //lipsSizeValue = lipsSize.value;
        ////faceLower
        //jawsPosValue = jawsSize.value;
        //jawsSizeValue = jawsSize.value;
        //chinPosValue = chinPos.value;
        //chinPronValue = chinPron.value;
        //chinSizeValue = chinSize.value;
        //mandibleSizeValue = mandibleSize.value;
        //neckThickValue = neckThick.value;

        //FEMALE
        //bodyUpper
        //armsValue = arms.value;
        //shouldersValue = shoudlers.value;
        breastsFemValue = breastsFem.value;
        //abdomenValue = abdomen.value;
        waistFemValue = waistFem.value;
        //bellyValue = belly.value;
        //bodylower
        gluteusFemValue = gluteusFem.value;
        //thighsValue = thighs.value;
        //calvesValue = calves.value;
        //feetValue = feet.value;
        ////general
        //heightValue = height.value;
        //weightValue = weight.value;

        //MALE
        armsMValue = armsM.value;
        shouldersMValue = shouldersM.value;
        abdomenMValue = abdomenM.value;

        //AndrogynousFem
        androgynousOrNotFem = androgynousOrNotTextFem.finalAndrogyny;

        //AndrogynousMale
        androgynousOrNotM = androgynousOrNotTextM.finalAndrogyny;

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
