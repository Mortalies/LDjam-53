using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavenTrigger : MonoBehaviour
{
    [SerializeField] private ScoreView _scoreView;
    public void Triggered(bool isSinner)
    {
        if (!isSinner)
            _scoreView.UpdateScore();
    }
}
