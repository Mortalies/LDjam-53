using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

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
<<<<<<< Updated upstream:Assets/Scripts/NPCs/SoulCharacter.cs
        // Диалоговое окно будет выскакивать. Данные буду браться из DialogueData
=======
        DialogueController.instance.SetDialogue(_dialogueData.messages);
        //DialogueController.instance.dialogueEndEvent.AddListener(AttachToTarget);
>>>>>>> Stashed changes:Assets/Scripts/SoulCharacters/SoulCharacter.cs
    }

    void Start()
    {

    }
    void Update()
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
