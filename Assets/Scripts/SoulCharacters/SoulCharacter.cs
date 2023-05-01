using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(SoulAnimation))]
[RequireComponent(typeof(SoulMovement))]
public class SoulCharacter : MonoBehaviour, IInteractable
{
    private bool _isSinner;
    [SerializeField] private DialogueData _dialogueData;
    private SoulMovement _movemet;
    public SoulMovement Movemet => _movemet;
    private SoulAnimation _animation;
    public delegate void soulMetDeath(SoulCharacter soul);
    public event soulMetDeath OnSoulMetDeath;
    public void Initialization(DialogueData dialogueData, bool isSinner)
    {
        _isSinner = isSinner;
        _dialogueData = dialogueData;
        _movemet = GetComponent<SoulMovement>();
        _animation = GetComponent<SoulAnimation>();
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
        _animation.Death();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<HeavenTrigger>() != null)
        {
            if (OnSoulMetDeath != null)
            {
                OnSoulMetDeath.Invoke(this);
            }
            HeavenTrigger heavenTrig = collision.gameObject.GetComponent<HeavenTrigger>();
            heavenTrig.Triggered(_isSinner);
            _animation.Death();
        }
    }


}
