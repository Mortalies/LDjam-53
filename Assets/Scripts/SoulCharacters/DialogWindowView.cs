using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class DialogWindowView : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _message;
    [SerializeField]private TextMeshProUGUI _name;
    [SerializeField]private GameObject _dialogueWindowPanel;
    void Awake()
    {
        _dialogueWindowPanel.SetActive(false);
        DialogueController.instance.dialogueEndEvent.AddListener(DeactivateDialogue);
    }
    public void ShowMessage(string name, string text)
    {
        _dialogueWindowPanel.SetActive(true);
        _name.text = name;
        _message.text = text;
    }
    private void DeactivateDialogue()
    {
        _dialogueWindowPanel.SetActive(false);
    }
    void Update()
    {
        
    }
}
