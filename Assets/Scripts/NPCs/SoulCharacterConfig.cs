using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Soul Character Config", menuName = "configs")]
public class SoulCharacterConfig:ScriptableObject
{
    public DialogueData dialogueData;
    public SoulCharacter prefab;
    public bool isSinner;
}
