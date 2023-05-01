using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    [SerializeField] private DialogueData _dialogueData;
    [SerializeField] private List<SoulCharacter> _souls;
    [SerializeField] private string _endTitleScene;
    public static GameStart instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }
    void Start()
    {
        DialogueController.instance.SetDialogue(_dialogueData.messages);
    }
    public void setSouls(List<SoulCharacter> souls)
    {
        _souls = souls;
        foreach (SoulCharacter soul in _souls)
        {
            soul.OnSoulMetDeath += deleteSoul;
        }
    }
    void deleteSoul(SoulCharacter soul)
    {
        _souls.Remove(soul);
        if (_souls.Count == 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(_endTitleScene);
        }
    }
    void Update()
    {
        
    }
}
