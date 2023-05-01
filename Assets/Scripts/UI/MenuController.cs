using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private string _playSceneName;
    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene(_playSceneName);
    }
    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
