using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCharactersFactory : ScriptableObject
{
    public SoulCharacter Spawn(SoulCharacterConfig config, Vector3 transform)
    {
        SoulCharacter instance = Instantiate(config.prefab, transform, Quaternion.identity);
        instance.Initialization(config.dialogueData);
        return instance;
    }
}
