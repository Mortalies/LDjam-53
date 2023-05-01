using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private string _playSceneName;
    [SerializeField] private Animator _animator;
    public void OnPlayButtonClick()
    {
        Debug.Log("Clicked");
        _animator.SetTrigger("Fade");
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
