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
    }
    void Start()
    {

        _dialogWindowView = gameObject.GetComponent<DialogWindowView>();
        //keyBoardInput.qDown.AddListener(NextMessage);
    }
    public void SetDialogue(List<Message> messages)
    {
        if(!isDialogueStarted)
        {
            _messages = messages;
            Debug.Log("Messages count= " + messages.Count);
            isDialogueStarted = true;
            NextMessage();
        }
    }
    public void NextMessage()
    {
        if(isDialogueStarted)
        {
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
        Debug.Log("End of dialogue");
    }
    public void Test()
    {
        Debug.Log("yasfjklasfjls");
    }
}
