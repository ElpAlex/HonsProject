using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;
using UnityEngine.UI;

public class CharacterCreator : MonoBehaviour
{
    public DynamicCharacterAvatar avatar;

    private Dictionary<string, DnaSetter> dna;

    //FACE
    //Top
    public Slider foreheadPosSlider;
    public Slider foreheadSizeSlider;
    public Slider eyesRotSlider;
    public Slider eyesSizeSlider;
    public Slider eyesSpacingSlider;
    public Slider earsSizeSlider;
    public Slider earsPosSlider;
    //Middle
    public Slider nosePosSlider;
    public Slider nosePronSizeSlider;
    public Slider noseSizeRotSlider;
    public Slider noseWidthSlider;
    public Slider cheekPosSlider;
    public Slider cheekSizeSlider;
    public Slider mouthSizeSlider;
    public Slider lipsSizeSlider;
    //Bottom
    public Slider jawsPosSlider;
    public Slider jawsSizeSlider;
    public Slider chinPosSlider;
    public Slider chinPronSlider;
    public Slider chinSizeSlider;
    public Slider mandibleSizeSlider;
    public Slider neckThickSlider;

    //BODY
    //UpperBody
    public Slider armSlider;
    public Slider shoulderSlider;
    public Slider breastsSlider;
    public Slider abdomenSlider;
    public Slider waistSlider;
    public Slider bellySlider;
    //LowerBody
    public Slider gluteusSlider;
    public Slider thighsSlider;
    public Slider calvesSlider;
    //public Slider feetSlider;
    ////Genral
    //public Slider heightSlider;
    //public Slider weightSlider;

    //for hair
    public List<string> hairModels = new List<string>();
    public int currentHair;

    private void OnEnable()
    {
        avatar.CharacterUpdated.AddListener(Updated);

        //faceTop
        foreheadPosSlider.onValueChanged.AddListener(ForeHeadPosChange);
        foreheadSizeSlider.onValueChanged.AddListener(ForeHeadSizeChange);
        eyesRotSlider.onValueChanged.AddListener(eyesRotChange);
        eyesSizeSlider.onValueChanged.AddListener(eyesSizeChange);
        eyesSpacingSlider.onValueChanged.AddListener(eyesSpacingChange);
        earsSizeSlider.onValueChanged.AddListener(earsSizeChange);
        earsPosSlider.onValueChanged.AddListener(earsPosChange);
        //faceMiddle
        nosePosSlider.onValueChanged.AddListener(nosePosChange);
        nosePronSizeSlider.onValueChanged.AddListener(nosePronChange);
        noseSizeRotSlider.onValueChanged.AddListener(noseSizeChange);
        noseWidthSlider.onValueChanged.AddListener(noseWidthChange);
        cheekPosSlider.onValueChanged.AddListener(cheekPosChange);
        cheekSizeSlider.onValueChanged.AddListener(cheekSizeChange);
        mouthSizeSlider.onValueChanged.AddListener(mouthSizeChange);
        lipsSizeSlider.onValueChanged.AddListener(lipsSizeChange);
        //faceBottom
        jawsPosSlider.onValueChanged.AddListener(JawsPosChange);
        jawsSizeSlider.onValueChanged.AddListener(JawsSizeChange);
        chinPosSlider.onValueChanged.AddListener(chinPosChange);
        chinPronSlider.onValueChanged.AddListener(chinPronChange);
        chinSizeSlider.onValueChanged.AddListener(chinSizeChange);
        mandibleSizeSlider.onValueChanged.AddListener(mandibleSizeChange);
        neckThickSlider.onValueChanged.AddListener(neckThickChange);

        //bodyUpper
        armSlider.onValueChanged.AddListener(ArmsChange);
        shoulderSlider.onValueChanged.AddListener(ShouldersChange);
        breastsSlider.onValueChanged.AddListener(BreastsChange);
        abdomenSlider.onValueChanged.AddListener(AbdomenChange);
        waistSlider.onValueChanged.AddListener(WaistChange);
        bellySlider.onValueChanged.AddListener(BellyChange);
        //bodylower
        gluteusSlider.onValueChanged.AddListener(GluteusChange);
        thighsSlider.onValueChanged.AddListener(ThighsChange);
        calvesSlider.onValueChanged.AddListener(CalvesChange);
        //feetSlider.onValueChanged.AddListener(FeetChange);
        ////general
        //heightSlider.onValueChanged.AddListener(HeightChange);
        //weightSlider.onValueChanged.AddListener(WeightChange);
    }

    private void OnDisable()
    {
        avatar.CharacterUpdated.RemoveListener(Updated);

        //faceTop
        foreheadPosSlider.onValueChanged.RemoveListener(ForeHeadPosChange);
        foreheadSizeSlider.onValueChanged.RemoveListener(ForeHeadSizeChange);
        eyesRotSlider.onValueChanged.RemoveListener(eyesRotChange);
        eyesSizeSlider.onValueChanged.RemoveListener(eyesSizeChange);
        eyesSpacingSlider.onValueChanged.RemoveListener(eyesSpacingChange);
        earsSizeSlider.onValueChanged.RemoveListener(earsSizeChange);
        earsPosSlider.onValueChanged.RemoveListener(earsPosChange);
        //faceMiddle
        nosePosSlider.onValueChanged.RemoveListener(nosePosChange);
        nosePronSizeSlider.onValueChanged.RemoveListener(nosePronChange);
        noseSizeRotSlider.onValueChanged.RemoveListener(noseSizeChange);
        noseWidthSlider.onValueChanged.RemoveListener(noseWidthChange);
        cheekPosSlider.onValueChanged.RemoveListener(cheekPosChange);
        cheekSizeSlider.onValueChanged.RemoveListener(cheekSizeChange);
        mouthSizeSlider.onValueChanged.RemoveListener(mouthSizeChange);
        lipsSizeSlider.onValueChanged.RemoveListener(lipsSizeChange);
        //facebottom
        jawsPosSlider.onValueChanged.RemoveListener(JawsPosChange);
        jawsSizeSlider.onValueChanged.RemoveListener(JawsSizeChange);
        chinPosSlider.onValueChanged.RemoveListener(chinPosChange);
        chinPronSlider.onValueChanged.RemoveListener(chinPronChange);
        chinSizeSlider.onValueChanged.RemoveListener(chinSizeChange);
        mandibleSizeSlider.onValueChanged.RemoveListener(mandibleSizeChange);
        neckThickSlider.onValueChanged.RemoveListener(neckThickChange);

        //bodyUpper
        armSlider.onValueChanged.RemoveListener(ArmsChange);
        shoulderSlider.onValueChanged.RemoveListener(ShouldersChange);
        breastsSlider.onValueChanged.RemoveListener(BreastsChange);
        abdomenSlider.onValueChanged.RemoveListener(AbdomenChange);
        waistSlider.onValueChanged.RemoveListener(WaistChange);
        bellySlider.onValueChanged.RemoveListener(BellyChange);
        //bodylower
        gluteusSlider.onValueChanged.RemoveListener(GluteusChange);
        thighsSlider.onValueChanged.RemoveListener(ThighsChange);
        calvesSlider.onValueChanged.RemoveListener(CalvesChange);
        //feetSlider.onValueChanged.RemoveListener(FeetChange);
        ////general
        //heightSlider.onValueChanged.RemoveListener(HeightChange);
        //weightSlider.onValueChanged.RemoveListener(WeightChange);
    }

    public void SwitchGender(bool male)
    {
        if (male && avatar.activeRace.name != "HumanMaleDCS")
            avatar.ChangeRace("HumanMaleDCS");
        if (!male && avatar.activeRace.name != "HumanFemaleDCS")
            avatar.ChangeRace("HumanFemaleDCS");
    }

    private void Updated(UMAData data)
    {
        dna = avatar.GetDNA();

        //faceTop
        foreheadPosSlider.value = dna["foreheadPosition"].Get();
        foreheadSizeSlider.value = dna["foreheadSize"].Get();
        eyesRotSlider.value = dna["eyeRotation"].Get();
        eyesSizeSlider.value = dna["eyeSize"].Get();
        eyesSpacingSlider.value = dna["eyeSpacing"].Get();
        earsSizeSlider.value = dna["earsSize"].Get();
        earsPosSlider.value = dna["earsPosition"].Get();
        //faceMiddle
        nosePosSlider.value = dna["nosePosition"].Get();
        nosePronSizeSlider.value = dna["nosePronounced"].Get();
        noseSizeRotSlider.value = dna["noseSize"].Get();
        noseWidthSlider.value = dna["noseWidth"].Get();
        cheekPosSlider.value = dna["cheekPosition"].Get();
        cheekSizeSlider.value = dna["cheekSize"].Get();
        mouthSizeSlider.value = dna["mouthSize"].Get();
        lipsSizeSlider.value = dna["lipsSize"].Get();
        //facebottom
        jawsPosSlider.value = dna["jawsPosition"].Get();
        jawsSizeSlider.value = dna["jawsSize"].Get();
        chinPosSlider.value = dna["chinPosition"].Get();
        chinPronSlider.value = dna["chinPronounced"].Get();
        chinSizeSlider.value = dna["chinSize"].Get();
        mandibleSizeSlider.value = dna["mandibleSize"].Get();
        neckThickSlider.value = dna["neckThickness"].Get();


        //bodyUpper
        armSlider.value = dna["armWidth"].Get();
        shoulderSlider.value = dna["upperMuscle"].Get();
        breastsSlider.value = dna["breastSize"].Get();
        abdomenSlider.value = dna["upperWeight"].Get();
        waistSlider.value = dna["waist"].Get();
        bellySlider.value = dna["belly"].Get();
        //bodylower
        gluteusSlider.value = dna["gluteusSize"].Get();
        thighsSlider.value = dna["lowerWeight"].Get();
        calvesSlider.value = dna["lowerMuscle"].Get();
        //feetSlider.value = dna["feetSize"].Get();
        ////general
        //heightSlider.value = dna["height"].Get();
    }

    //FACE
    //top
    public void ForeHeadPosChange(float val)
    {
        dna["foreheadPosition"].Set(val);
        avatar.BuildCharacter();
    }
    public void ForeHeadSizeChange(float val)
    {
        dna["foreheadSize"].Set(val);
        avatar.BuildCharacter();
    }
    public void eyesRotChange(float val)
    {
        dna["eyeRotation"].Set(val);
        avatar.BuildCharacter();
    }
    public void eyesSizeChange(float val)
    {
        dna["eyeSize"].Set(val);
        avatar.BuildCharacter();
    }
    public void eyesSpacingChange(float val)
    {
        dna["eyeSpacing"].Set(val);
        avatar.BuildCharacter();
    }
    public void earsSizeChange(float val)
    {
        dna["earsSize"].Set(val);
        avatar.BuildCharacter();
    }
    public void earsPosChange(float val)
    {
        dna["earsPosition"].Set(val);
        avatar.BuildCharacter();
    }
    //middle
    public void nosePosChange(float val)
    {
        dna["nosePosition"].Set(val);
        avatar.BuildCharacter();
    }
    public void nosePronChange(float val)
    {
        dna["nosePronounced"].Set(val);
        avatar.BuildCharacter();
    }
    public void noseSizeChange(float val)
    {
        dna["noseSize"].Set(val);
        avatar.BuildCharacter();
    }
    public void noseWidthChange(float val)
    {
        dna["noseWidth"].Set(val);
        avatar.BuildCharacter();
    }
    public void cheekPosChange(float val)
    {
        dna["cheekPosition"].Set(val);
        avatar.BuildCharacter();
    }
    public void cheekSizeChange(float val)
    {
        dna["cheekSize"].Set(val);
        avatar.BuildCharacter();
    }
    public void mouthSizeChange(float val)
    {
        dna["mouthSize"].Set(val);
        avatar.BuildCharacter();
    }
    public void lipsSizeChange(float val)
    {
        dna["lipsSize"].Set(val);
        avatar.BuildCharacter();
    }

    //bottom
    public void JawsPosChange(float val)
    {
        dna["jawsPosition"].Set(val);
        avatar.BuildCharacter();
    }
    public void JawsSizeChange(float val)
    {
        dna["jawsSize"].Set(val);
        avatar.BuildCharacter();
    }
    public void chinPosChange(float val)
    {
        dna["chinPosition"].Set(val);
        avatar.BuildCharacter();
    }
    public void chinPronChange(float val)
    {
        dna["chinPronounced"].Set(val);
        avatar.BuildCharacter();
    }
    public void chinSizeChange(float val)
    {
        dna["chinSize"].Set(val);
        avatar.BuildCharacter();
    }
    public void mandibleSizeChange(float val)
    {
        dna["mandibleSize"].Set(val);
        avatar.BuildCharacter();
    }
    public void neckThickChange(float val)
    {
        dna["neckThickness"].Set(val);
        avatar.BuildCharacter();
    }

    //BODY
    public void ArmsChange(float val)
    {
        dna["armWidth"].Set(val);
        dna["forearmWidth"].Set(val);
        avatar.BuildCharacter();
    }
    public void ShouldersChange(float val)
    {
        dna["upperMuscle"].Set(val);
        avatar.BuildCharacter();
    }

    public void BreastsChange(float val)
    {
        dna["breastSize"].Set(val);
        avatar.BuildCharacter();
    }

    public void AbdomenChange(float val)
    {
        dna["upperWeight"].Set(val);
        avatar.BuildCharacter();
    }

    public void WaistChange(float val)
    {
        dna["waist"].Set(val);
        avatar.BuildCharacter();
    }

    public void BellyChange(float val)
    {
        dna["belly"].Set(val);
        avatar.BuildCharacter();
    }

    public void GluteusChange(float val)
    {
        dna["gluteusSize"].Set(val);
        avatar.BuildCharacter();
    }

    public void ThighsChange(float val)
    {
        dna["lowerWeight"].Set(val);
        avatar.BuildCharacter();
    }

    public void CalvesChange(float val)
    {
        dna["lowerMuscle"].Set(val);
        avatar.BuildCharacter();
    }

    //public void FeetChange(float val)
    //{
    //    dna["feetSize"].Set(val);
    //    avatar.BuildCharacter();
    //}

    //public void HeightChange(float val)
    //{
    //    dna["height"].Set(val);
    //    avatar.BuildCharacter();
    //}

    //public void WeightChange(float val)
    //{
    //    dna["belly"].Set(val);
    //    dna["cheekSize"].Set(val);
    //    dna["armWidth"].Set(val);
    //    dna["breastSize"].Set(val);
    //    dna["forearmWidth"].Set(val);
    //    dna["gluteusSize"].Set(val);
    //    dna["jawsSize"].Set(val);
    //    dna["lowerMuscle"].Set(val);
    //    dna["lowerWeight"].Set(val);
    //    dna["neckThickness"].Set(val);
    //    dna["waist"].Set(val);
    //    dna["upperMuscle"].Set(val);
    //    dna["upperWeight"].Set(val);
    //    avatar.BuildCharacter();
    //}

    public void ChangeHair (bool plus)
    {
        if (plus)
            currentHair++;
        else
            currentHair--;

        currentHair = Mathf.Clamp(currentHair, 0, hairModels.Count - 1);

        if (hairModels[currentHair] == "None")
        {
            avatar.ClearSlot("Hair");
        }
        else
            avatar.SetSlot("Hair", hairModels[currentHair]);

        avatar.BuildCharacter();
    }
}
