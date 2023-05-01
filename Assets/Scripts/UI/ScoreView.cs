using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _infoText;

    private int _score;
    public static ScoreView instance;
    void Start()
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
    public void UpdateScore()
    {
        _score++;
        _scoreText.text = "SCORE: " + _score;
    }
    public void UpdateInfo(string info)
    {
        _infoText.text = info;
    }
}
