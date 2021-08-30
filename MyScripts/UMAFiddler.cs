using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

//REFERENCES
//script author: Secret Anorak (https://www.youtube.com/watch?v=wZ3fM1iya98&list=PLkDHFObfS19zFVfbrfB14P-u5QJJQyvtP&index=9)

public class UMAFiddler : MonoBehaviour
{
    private DynamicCharacterAvatar avatar;
    private Dictionary<string, DnaSetter> dna;

    // Start is called before the first frame update
    void Start()
    {
        avatar = GetComponent<DynamicCharacterAvatar>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            avatar.SetSlot("Chest", "MaleHoodie_Recipe");
            avatar.BuildCharacter();
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            avatar.ClearSlot("Chest");
            avatar.BuildCharacter();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if(dna ==null)
            {
                dna = avatar.GetDNA();
            }

            dna["headSize"].Set(1f);
            avatar.BuildCharacter();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            avatar.SetColor("Hair", Color.black);
            avatar.BuildCharacter();
        }

    }
}
