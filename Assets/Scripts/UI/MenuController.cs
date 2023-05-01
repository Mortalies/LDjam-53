using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private string _playSceneName;
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioSource _buttonClickSound;
    [SerializeField] private AudioSource _backgroundMusic;
    private bool isClicked = false;
    public void OnPlayButtonClick()
    {
        _animator.SetTrigger("Fade");
        _buttonClickSound.Play();
        isClicked = true;
    }

    private void Update()
    {
        if (isClicked)
            _backgroundMusic.volume = Mathf.MoveTowards(_backgroundMusic.volume, 0f, 0.125f);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(_playSceneName);
    }
    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
