using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public struct questInfo
{
    public int key;
    public string info;
}
public class QuestStateMachine: MonoBehaviour
{
    [SerializeField] private List<string> _statesInfo = new List<string>();
    [SerializeField] private QuestState _currentState;
    [SerializeField] private ScoreView _infoView;

    public static QuestStateMachine instance;
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
    private void Start()
    {
        DialogueController.instance.dialogueEndEvent.AddListener(SecondState);
        FirstState();
    }
    public void FirstState()
    {
        _currentState = QuestState.FindSoul;
        _infoView.UpdateInfo(_statesInfo[0]);
    }
    public void SecondState()
    {
        _currentState = QuestState.ChoseFate;
        _infoView.UpdateInfo(_statesInfo[1]);
    }
    public void ToState(QuestState state)
    {
        _currentState = state;
        switch(_currentState)
        {
            case QuestState.ChoseFate:
                SecondState();
                break;
            case QuestState.FindSoul:
                FirstState();
                break;
            default:
                FirstState();
                break;
        }
    }
    
}
