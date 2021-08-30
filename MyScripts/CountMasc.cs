using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountMasc : MonoBehaviour
{
    int total;
    public string finalAndrogyny;

    public List<ToggleDistribution> mascToggles = new List<ToggleDistribution>();
    public int mascCount;

    public List<ToggleDistribution> femToggles = new List<ToggleDistribution>();
    public int femCount;

    public List<ToggleDistribution> neutToggles = new List<ToggleDistribution>();
    public int neutCount;

    public void countMasculine()
    {
        for (int i=0; i<mascToggles.Count; i++)
        {
            mascCount+= mascToggles[i].count ;
        }
        for (int i = 0; i < femToggles.Count; i++)
        {
            femCount += femToggles[i].count;
        }
        for (int i = 0; i < neutToggles.Count; i++)
        {
            neutCount += neutToggles[i].count;
        }

        Debug.Log(mascCount);
        Debug.Log(femCount);
        Debug.Log(neutCount);

        total = mascCount - femCount;
        Debug.Log(total);

        if (total >= 20)
            finalAndrogyny = "Masculine";
        else if (total >= 10 && total <=19)
            finalAndrogyny = "Nearly Masculine";
        else if (total <= 9 && total >= -9)
            finalAndrogyny = "Androgynous";
        else if (total <= -10 && total >= -19)
            finalAndrogyny = "Nearly Feminine";
        else if (total <= -20)
            finalAndrogyny = "Feminine";

        Debug.Log(finalAndrogyny);
    }
}
