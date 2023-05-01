using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCharacter : MonoBehaviour, IInteractable
{
    private bool _isSinner;
    private TargetMovement _targetMovement;
    [SerializeField] private DialogueData _dialogueData;
    public void Initialization(DialogueData dialogueData)
    {
        _dialogueData = dialogueData;
    }
    public void Interact()
    {
        DialogueController.instance.SetDialogue(_dialogueData.messages);
        DialogueController.instance.dialogueEndEvent.AddListener(AttachToTarget);
    }
    public void AttachToTarget()
    {
        _targetMovement = GetComponent<TargetMovement>();
        _targetMovement.ActivateMovement();
    }
    public void ApplyDamage()
    {
        
    }
}
