using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class User 
{
    public string Aa_username;
    public string Ab_age;
    public string Ac_gender;

    //body female
    //public float Bfem_arms;
    //public float Cfem_shoulders;
    //public float Efem_abdomen;
    //public float Gfem_belly;
    //public float Ifem_thighs;
    //public float Jfem_calves;
    //public float Kfem_feet;
    //public float Lfem_height;
    //public float M_weight;
    public float BaFem_breasts;
    public float BbFem_waist;
    public float BcFem_gluteus;


    //body male
    public float CaM_arms;
    public float CbM_shoulders;
    public float CcM_abdomen;
    //public float Fm_waist;
    //public float Gm_belly;
    //public float Hm_gluteus;
    //public float Im_thighs;
    //public float Jm_calves;
    //public float Km_feet;
    //public float Lm_height;

    ////facetop
    //public float Na_foreheadPos;
    //public float Nb_foreheadSize;
    //public float Oa_eyesRot;
    //public float Ob_eyesSize;
    //public float Oc_eyesSpacing;
    //public float Pa_earsSize;
    //public float Pb_earsPos;

    ////faceMiddle
    //public float Qa_nosePos;
    //public float Qb_nosePron;
    //public float Qc_noseSize;
    //public float Qd_noseWidth;
    //public float Ra_cheekPos;
    //public float Rb_cheekSize;
    //public float S_mouthSize;
    //public float T_lipsSize;

    ////faceBottom
    //public float Ua_jawsPos;
    //public float Ub_jawsSize;
    //public float Va_chinPos;
    //public float Vb_chinPron;
    //public float Vc_chinSize;
    //public float W_mandibleSize;
    //public float X_neckThick;

    //AndrogynousFemale
    public string DFem_androgynousOrNot;
    //AndrogynousFemale
    public string DM_androgynousOrNot;

    //Questionnaire Toggles
    public string Za_answerOne;
    public string Zb_answerTwo;
    public string Zc_answerThree;
    public string Zd_answerFour;
    public string Ze_answerFive;
    public string Zf_answerSix;
    public string Zg_answerSeven;
    public string Zh_answerEight;
    public string Zi_answerNine;
    public string Zj_answerTen;
    public string Zk_answerEleven;

    public User()
    {
        Aa_username = UserData.playerName;
        Ab_age = UserData.playerAge;
        Ac_gender = UserData.playerGender;

        //Bfem_arms = UserData.armsValue;
        //Cfem_shoulders = UserData.shouldersValue;
        //Efem_abdomen = UserData.abdomenValue;
        //Gfem_belly = UserData.bellyValue;
        //Ifem_thighs = UserData.thighsValue;
        //Jfem_calves = UserData.calvesValue;
        //Kfem_feet = UserData.feetValue;
        //Lfem_height = UserData.heightValue;
        //M_weight = UserData.weightValue;
        BaFem_breasts = UserData.breastsFemValue;
        BbFem_waist = UserData.waistFemValue;
        BcFem_gluteus = UserData.gluteusFemValue;

        ////FaceTop
        //Na_foreheadPos = UserData.foreheadPosValue;
        //Nb_foreheadSize = UserData.foreheadSizeValue;
        //Oa_eyesRot = UserData.eyesRotValue;
        //Ob_eyesSize = UserData.eyesSizeValue;
        //Oc_eyesSpacing = UserData.eyesSpacingValue;
        //Pa_earsSize = UserData.earsSizeValue;
        //Pb_earsPos = UserData.earsPosValue;

        ////faceMiddle
        //Qa_nosePos = UserData.nosePosValue;
        //Qb_nosePron = UserData.nosePronValue;
        //Qc_noseSize = UserData.noseSizeValue;
        //Qd_noseWidth = UserData.noseWidthValue;
        //Ra_cheekPos = UserData.cheekPosValue;
        //Rb_cheekSize = UserData.cheekSizeValue;
        //S_mouthSize = UserData.mouthSizeValue;
        //T_lipsSize = UserData.lipsSizeValue;

        ////faceBottom
        //Ua_jawsPos = UserData.jawsPosValue;
        //Ub_jawsSize = UserData.jawsSizeValue;
        //Va_chinPos = UserData.chinPosValue;
        //Vb_chinPron = UserData.chinPronValue;
        //Vc_chinSize = UserData.chinSizeValue;
        //W_mandibleSize = UserData.mandibleSizeValue;
        //X_neckThick = UserData.neckThickValue;

        //MALE
        CaM_arms = UserData.armsMValue;
        CbM_shoulders = UserData.shouldersMValue;
        CcM_abdomen = UserData.abdomenMValue;

       //AndrogynousFem
        DFem_androgynousOrNot = UserData.androgynousOrNotFem;
        //AndrogynousMale
        DM_androgynousOrNot = UserData.androgynousOrNotM;

        //Questionnaire Toggles
        Za_answerOne = UserData.questionOneAnswer;
        Zb_answerTwo = UserData.questionTwoAnswer;
        Zc_answerThree = UserData.questionThreeAnswer;
        Zd_answerFour = UserData.questionFourAnswer;
        Ze_answerFive = UserData.questionFiveAnswer;
        Zf_answerSix = UserData.questionSixAnswer;
        Zg_answerSeven = UserData.questionSevenAnswer;
        Zh_answerEight = UserData.questionEightAnswer;
        Zi_answerNine = UserData.questionNineAnswer;
        Zj_answerTen = UserData.questionTenAnswer;
        Zk_answerEleven = UserData.questionElevenAnswer;

    }
}
