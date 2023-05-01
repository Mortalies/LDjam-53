using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SoulMovement))]
public class SoulCharacter : MonoBehaviour, IInteractable
{
    [SerializeField] private DialogueData _dialogueData;
    private SoulMovement _soulMovement;
    public SoulMovement SoulMovement => _soulMovement;
    
    public void Awake()
    {
        _soulMovement = GetComponent<SoulMovement>();
    }
    
    public void Initialization(DialogueData dialogueData)
    {
        _dialogueData = dialogueData;
    }
    public void Interact()
    {
        if (_dialogueData == null)
            return;
        
        DialogueController.instance.SetDialogue(_dialogueData.messages);
    }
    public void ApplyDamage()
    {
        
    }
}
