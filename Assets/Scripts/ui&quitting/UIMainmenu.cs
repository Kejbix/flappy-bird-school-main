using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIMainmenu : MonoBehaviour
{
    [SerializeField] private string play;
    [SerializeField] private string settings;
    [SerializeField] private string credits;
    [SerializeField] private string menu;

    public void Settingsopen()
    {
        SceneManager.LoadSceneAsync(settings);
    }
    public void Menuopen()
    {
        SceneManager.LoadSceneAsync(menu);
    }
    public void Creditsopen()
    {
        SceneManager.LoadSceneAsync(credits);
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(play);
    }

    public void EndGame()
    {
        Application.Quit();
    }

}
