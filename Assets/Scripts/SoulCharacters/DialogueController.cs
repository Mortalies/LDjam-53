using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Events;
using UnityEngine.Events;
using Mono.Cecil;

[RequireComponent(typeof(DialogWindowView))]
public class DialogueController : MonoBehaviour
{
    private DialogWindowView _dialogWindowView;
    private List<Message> _messages;
    private int messageCount = 0;
    public UnityEvent dialogueEndEvent = new UnityEvent();
    private bool isDialogueStarted = false;
    public static DialogueController instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        _dialogWindowView = gameObject.GetComponent<DialogWindowView>();
    }
    void Start()
    {

        
        //keyBoardInput.qDown.AddListener(NextMessage);
    }
    public void SetDialogue(List<Message> messages)
    {
        
        if(!isDialogueStarted)
        {
            Debug.Log("dialogueStarted");
            _messages = messages;
            isDialogueStarted = true;
            NextMessage();
        }
    }
    public void NextMessage()
    {
        if(isDialogueStarted)
        {
            Debug.Log("next message" + _messages.Count);
            if (messageCount >= _messages.Count)
            {
                EndOfDialogue();
                return;
            }
            _dialogWindowView.ShowMessage(_messages[messageCount].name, _messages[messageCount].value);
            messageCount++;
        }
    }
    void EndOfDialogue()
    {
        if (dialogueEndEvent != null)
            dialogueEndEvent.Invoke();
        messageCount = 0;
        isDialogueStarted = false;
    }
}
