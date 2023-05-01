using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoulCharacter : MonoBehaviour, IInteractable
{
    private bool _isSinner;
    private TargetMovement _targetMovement;
    [SerializeField] private DialogueData _dialogueData;

    public UnityEvent soulMetHeaven = new UnityEvent();
    public void Initialization(DialogueData dialogueData, bool isSinner)
    {
        _isSinner = isSinner;
        _dialogueData = dialogueData;
    }
    public void Interact()
    {
        DialogueController.instance.SetDialogue(_dialogueData.messages);
    }

    void Start()
    {

    }
    void Update()
    {
        
    }
    public void ApplyDamage()
    {
        if (_isSinner)
            ScoreView.instance.UpdateScore();
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<HeavenTrigger>() != null)
        {
            if (soulMetHeaven != null)
            {
                soulMetHeaven.Invoke();
            }
            HeavenTrigger heavenTrig = collision.gameObject.GetComponent<HeavenTrigger>();
            heavenTrig.Triggered(_isSinner);
            gameObject.SetActive(false);
        }
    }
}
