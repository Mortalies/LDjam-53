using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoulCharacter : MonoBehaviour, IInteractable
{
    private bool _isSinner;
    [SerializeField] private DialogueData _dialogueData;
    private SoulMovement _soulMovement;
    public SoulMovement SoulMovement => _soulMovement;
    public delegate void soulMetDeath(SoulCharacter soul);
    public event soulMetDeath OnSoulMetDeath;
    public void Initialization(DialogueData dialogueData, bool isSinner)
    {
        _isSinner = isSinner;
        _dialogueData = dialogueData;
        _soulMovement = GetComponent<SoulMovement>();
    }
    public void Interact()
    {
        DialogueController.instance.SetDialogue(_dialogueData.messages);
    }
    

    public void Awake()
    {
        
    }
    public void ApplyDamage()
    {
        if (_isSinner)
            ScoreView.instance.UpdateScore();
        Death();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<HeavenTrigger>() != null)
        {
            
            HeavenTrigger heavenTrig = collision.gameObject.GetComponent<HeavenTrigger>();
            heavenTrig.Triggered(_isSinner);
            Death();
        }
    }
    void Death()
    {
        if (OnSoulMetDeath != null)
        {
            OnSoulMetDeath.Invoke(this);
        }
        gameObject.SetActive(false);
    }
    
    
}
